using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

using Tyuiu.KomarovMI.Sprint7.Project.V7.Lib;

namespace Tyuiu.KomarovMI.Sprint7.Project.V7
{
    public partial class FormFunction : Form
    {
        DataService ds = new DataService();
        private int compMode = 0;
        public FormFunction()
        {
            InitializeComponent();
            openFileDialog_KMI.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_KMI.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog_KMI.ShowDialog() != DialogResult.Cancel)
            {
                string filepath = openFileDialog_KMI.FileName;
                var rows = DataGridView_KMI.Rows;
                string[] content = File.ReadAllLines(filepath, Encoding.Default);
                DataGridView_KMI.RowCount = content.Length;
                for (int i = 0; i < content.Length; i++)
                {
                    for (int j = 0; j < content[0].Split(';').Length; j++)
                    {
                        rows[i].Cells[j].Value = content[i]?.Split(';')[j];
                    }
                }
            }
        }

        private void сохранитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog_KMI.FileName = "Домоуправление";
            saveFileDialog_KMI.InitialDirectory = Directory.GetCurrentDirectory();
            if (saveFileDialog_KMI.ShowDialog() != DialogResult.Cancel)
            {
                string filepath = saveFileDialog_KMI.FileName;
                var rows = DataGridView_KMI.Rows;
                string[] content = new string[rows.Count];
                for (int i = 0; i < rows.Count; i++)
                {
                    for (int j = 0; j < rows[i].Cells.Count; j++)
                    {
                        if (j != rows[i].Cells.Count - 1)
                        {
                            content[i] += rows[i].Cells[j].Value?.ToString() + ';';
                        }
                        else
                        {
                            content[i] += rows[i].Cells[j].Value?.ToString();
                        }
                    }
                }
                File.WriteAllLines(filepath, content, Encoding.UTF8);
            }
        }

        private void DataGridView_KMI_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                chart_KMI.Series[0].Points.Clear();
                foreach (DataGridViewRow row in DataGridView_KMI.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[2].Value != null)
                    {
                        chart_KMI.Series[0].Points.AddXY(Convert.ToDouble(row.Cells[1].Value), Convert.ToDouble(row.Cells[2].Value));
                    }
                }
            }
        }

        private void DataGridView_KMI_SelectionChanged(object sender, EventArgs e)
        {
            textBoxCount_KMI.Text = DataGridView_KMI.SelectedCells.Count.ToString();
            List<double> cellsValues = new List<double>();
            foreach (DataGridViewCell cell in DataGridView_KMI.SelectedCells)
            {
                if (cell.Value != null && double.TryParse(cell.Value.ToString().Replace('.', ','), out double cellValue))
                {
                    cellsValues.Add(cellValue);
                }
            }
            if (cellsValues.Count > 0)
            {
                textBoxSum_KMI.Text = ds.Calculation(cellsValues, "Sum").ToString();
                textBoxMid_KMI.Text = ds.Calculation(cellsValues, "Mid").ToString();
                textBoxMin_KMI.Text = ds.Calculation(cellsValues, "Min").ToString();
                textBoxMax_KMI.Text = ds.Calculation(cellsValues, "Max").ToString();
                cellsValues.Clear();
            }
            else
            {
                textBoxSum_KMI.Clear();
                textBoxMid_KMI.Clear();
                textBoxMin_KMI.Clear();
                textBoxMax_KMI.Clear();
            }
        }



        private void DataGridView_KMI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxSearch_KMI_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch_KMI.Text?.ToLower().Trim();
            var rows = DataGridView_KMI.Rows;
            if (!string.IsNullOrEmpty(search))
            {
                foreach (DataGridViewRow row in rows)
                {
                    List<string> cellsValues = new List<string>();
                    for (int i = 1; i < row.Cells.Count; i++)
                    {
                        string cellValue = row.Cells[i].Value?.ToString().ToLower();
                        if (!string.IsNullOrEmpty(cellValue))
                        {
                            cellsValues.Add(cellValue);
                        }
                    }
                    bool isVisible = cellsValues.Any(x => x.Contains(search));
                    row.Visible = isVisible;
                }
            }
            else
            {
                foreach (DataGridViewRow row in rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void добавитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView_KMI.Rows.Add();
        }

        private void удалитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = DataGridView_KMI.SelectedCells[0].RowIndex;
            DataGridView_KMI.Rows.RemoveAt(selectedRowIndex);
        }

        private void buttonOK_KMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
