using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Workers.DoanhThu
{
    public partial class DoanhThu : Form
    {
        Classes.Xe.Xe xe = new Classes.Xe.Xe();
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from XeDap where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            DataTable data = xe.LayDSXe(sqlCommand);
            int t = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                t += Convert.ToInt32(data.Rows[i].ItemArray[5]) + Convert.ToInt32(data.Rows[i].ItemArray[6]);
            }
            //doanh thu xe may
            sqlCommand = new SqlCommand("Select * from XeMay where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            data = xe.LayDSXe(sqlCommand);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                t += Convert.ToInt32(data.Rows[i].ItemArray[5]) + Convert.ToInt32(data.Rows[i].ItemArray[6]);
            }
            //doanh thu xe hoi
            sqlCommand = new SqlCommand("Select * from XeHoi where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            data = xe.LayDSXe(sqlCommand);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                t += Convert.ToInt32(data.Rows[i].ItemArray[5]) + Convert.ToInt32(data.Rows[i].ItemArray[6]);
            }
            textBoxTongDoanhThu.Text = t.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonTongHop_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from XeDap where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            DataTable dataXeDap = xe.LayDSXe(sqlCommand);
            int t = 0;
            for (int i = 0; i < dataXeDap.Rows.Count; i++)
            {
                t += Convert.ToInt32(dataXeDap.Rows[i].ItemArray[5]) + Convert.ToInt32(dataXeDap.Rows[i].ItemArray[6]);
            }
            //doanh thu xe may
            sqlCommand = new SqlCommand("Select * from XeMay where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            DataTable dataXeMay = xe.LayDSXe(sqlCommand);
            for (int i = 0; i < dataXeMay.Rows.Count; i++)
            {
                t += Convert.ToInt32(dataXeMay.Rows[i].ItemArray[5]) + Convert.ToInt32(dataXeMay.Rows[i].ItemArray[6]);
            }
            //doanh thu xe hoi
            sqlCommand = new SqlCommand("Select * from XeHoi where TinhTrangTra=@tinhtrang");
            sqlCommand.Parameters.Add("@tinhtrang", SqlDbType.NChar).Value = "Da Tra";
            DataTable dataXeHoi = xe.LayDSXe(sqlCommand);
            for (int i = 0; i < dataXeHoi.Rows.Count; i++)
            {
                t += Convert.ToInt32(dataXeHoi.Rows[i].ItemArray[5]) + Convert.ToInt32(dataXeHoi.Rows[i].ItemArray[6]);
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(t,dataXeDap,dataXeMay,dataXeHoi, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Export_Data_To_Word(int t, DataTable dataXeDap, DataTable dataXeMay, DataTable dataXeHoi, string fileName)
        {
            Microsoft.Office.Interop.Word.Application objWord = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document objDoc = objWord.Documents.Add();
            //tua de bang diem sinh vien
            Microsoft.Office.Interop.Word.Paragraph objPara;
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "TỔNG CHI PHÍ";
            objPara.Range.Font.Name = "Times New Roman";
            objPara.Range.Font.Size = 18;
            objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            objPara.Range.Bold = 1;
            objPara.Range.InsertParagraphAfter();
            //muc Chi phi xe
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "Tổng chi phí tất cả xe";
            objPara.Range.Font.Name = "Times New Roman";
            objPara.Range.Font.Size = 11;
            objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            objPara.Range.Bold = 1;
            objPara.Range.Italic = 1;
            objPara.Range.InsertParagraphAfter();
            //muc thanh tien
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.Text = "Thành tiền: " + t.ToString()+" VND";
            objPara.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
            objPara.Range.Bold = 0;
            objPara.Range.Italic = 0;
            objPara.Range.InsertParagraphAfter();
            
            //ve table bang diem sinh vien
            int rowCount = dataXeDap.Rows.Count;
            int columnCount = dataXeDap.Columns.Count;
            Object[,] dataArray = new object[rowCount, columnCount];
            int r = 0;
            for (int c = 0; c < columnCount; c++)
            {
                for (r = 0; r < rowCount; r++)
                {
                    dataArray[r, c] = dataXeDap.Rows[r].ItemArray[c];
                }
            }
            dynamic oRange = objDoc.Content.Application.Selection.Range;
            string oTemp = "";
            for (r = 0; r < rowCount; r++)
            {
                oTemp = oTemp + dataArray[r, 0] + "\t" + dataArray[r, 1] + "\t" + dataArray[r, 2] + "\t";
            }
            //table format
            oRange.Text = oTemp;
            object seperator = Microsoft.Office.Interop.Word.WdTableFieldSeparator.wdSeparateByTabs;
            object applyBorders = true;
            object autoFit = true;
            object autoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;
            oRange.ConvertToTable(ref seperator, ref rowCount, ref columnCount, Type.Missing, Type.Missing,
                ref applyBorders, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                ref autoFit, ref autoFitBehavior, Type.Missing);
            oRange.Select();
            objDoc.Application.Selection.Tables[1].Select();
            objDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
            objDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
            objDoc.Application.Selection.Tables[1].Rows[1].Select();
            objDoc.Application.Selection.InsertRowsAbove(1);
            objDoc.Application.Selection.Tables[1].Rows[1].Select();
            //header row style
            objDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
            objDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
            objDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;
            //add header row manually
            objDoc.Application.Selection.Tables[1].Cell(1, 1).Range.Text = "Khóa học";
            objDoc.Application.Selection.Tables[1].Cell(1, 2).Range.Text = "Điểm";
            objDoc.Application.Selection.Tables[1].Cell(1, 3).Range.Text = "Chú thích";
            //table style
            objDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
            objDoc.Application.Selection.Tables[1].Rows[1].Select();
            objDoc.Application.Selection.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            objPara = objDoc.Paragraphs.Add();
            objPara.Range.InsertParagraphAfter();
            foreach (Microsoft.Office.Interop.Word.Section section in objDoc.Application.ActiveDocument.Sections)
            {
                Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                headerRange.Text = "Tổng hợp doanh thu";
                headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            }
            //luu file
            objWord.Visible = true;
            objWord.WindowState = Microsoft.Office.Interop.Word.WdWindowState.wdWindowStateNormal;
            objDoc.SaveAs(fileName);
        }

    }

}
