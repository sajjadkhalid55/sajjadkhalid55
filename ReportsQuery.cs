using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LMS
{
  public  class ReportsQuery
    {
      public static string ListViewQuery(ListView LV, string Tbl,string Column)
      {
          string query = "{" + Tbl + "." + Column + "} in [";

          int a = LV.Items.Count;

          foreach (ListViewItem row in LV.Items)
          {
              if (a >= 1)
              {
                  if (a != 1)
                  {
                      // MessageBox.Show( row.Cells[0].Value.ToString() + ",");
                      query += "" + row.SubItems[0].Text.ToString() + ",";
                  }
                  else
                  {
                      query += "" + row.SubItems[0].Text.ToString() + "]";
                  }
              }
              a--;
          }
          return query;

      }
      public static string GrideQuery(DataGridView DG, string Tbl, string Column)
      {
          string query = "{" + Tbl + "." + Column + "} in [";
          int a = DG.Rows.Count;

          foreach (DataGridViewRow row in DG.Rows)
          {
              if (a > 1)
              {
                  if (a != 2)
                  {
                      // MessageBox.Show( row.Cells[0].Value.ToString() + ",");
                      query += "" + row.Cells[0].Value.ToString() + ",";
                  }
                  else
                  {
                      query += "" + row.Cells[0].Value.ToString() + "]";
                  }
              }
              a--;
          }
          return query;
      }
      public static string MultiColumnGrideQuery(DataGridView DG, string Tbl, string Emp, string Machine, string Date,string Shift)
      {
          string query = "{" + Tbl + "." + Emp + "},{" + Tbl + "." + Machine + "},{" + Tbl + "." + Shift + "}, {" + Tbl + "." + Date + "}in [";
          int a = DG.Rows.Count;

          foreach (DataGridViewRow row in DG.Rows)
          {
              if (a > 1)
              {
                  if (a != 2)
                  {
                      // MessageBox.Show( row.Cells[0].Value.ToString() + ",");
                      query += "" + row.Cells[0].Value.ToString() + ",";
                  }
                  else
                  {
                      query += "" + row.Cells[0].Value.ToString() + "]";
                  }
              }
              a--;
          }
          return query;
      }
    }
}
