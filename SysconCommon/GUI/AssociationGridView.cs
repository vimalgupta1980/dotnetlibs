using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SysconCommon.Algebras.DataTables;

namespace SysconCommon.GUI
{
    public partial class AssociationGridView : DataGridView
    {
        private IEnumerable<object> FirstList;
        private IEnumerable<object> SecondList;
        public DataTable Data;

        public AssociationGridView()
        {
            InitializeComponent();
        }

        public void Setup(string FirstHeader, IEnumerable<object> FirstList, string SecondHeader, IEnumerable<object> SecondList)
        {
            Setup(FirstHeader, FirstList, SecondHeader, SecondList, null);
        }

        public void Setup(string FirstHeader, IEnumerable<object> FirstList, string SecondHeader, IEnumerable<object> SecondList, DataTable sourceData)
        {
            this.InitializeComponent();
            this.FirstList = FirstList;
            this.SecondList = SecondList;

            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;

            this.Columns.Clear();
            var col1 = new DataGridViewTextBoxColumn();
            col1.ReadOnly = true;
            this.Columns.Add(col1);

            var data = sourceData != null
                    ? sourceData
                    : (from x in FirstList
                       from y in new object[] { null }
                       select new { x, y }).ToDataTable("Data");


            var secondCol = new DataGridViewComboBoxColumn();
            var secondTemplate = new DataGridViewComboBoxCell();
            secondTemplate.DataSource = SecondList.Select(i => new { i }).ToDataTable("Combo Items");
            secondTemplate.DisplayMember = "i";
            secondCol.CellTemplate = secondTemplate;

            this.Columns.Add(secondCol);

            this.Columns[0].Width = (int)(this.Width * 0.40);
            this.Columns[1].Width = (int)(this.Width * 0.40);
            this.Columns[0].HeaderText = FirstHeader;
            this.Columns[1].HeaderText = SecondHeader;
            this.Columns[0].DataPropertyName = "x";
            this.Columns[1].DataPropertyName = "y";

            this.DataSource = data;
            this.Data = data;

            // this.DataError += new DataGridViewDataErrorEventHandler(AssociationGridView_DataError);
        }

        public IEnumerable<Tuple<object, object>> Associations
        {
            get
            {
                foreach (DataRow row in this.Data.Rows)
                {
                    if (row[1] != null)
                    {
                        yield return new Tuple<object, object>(row[0], row[1]);
                    }
                }
            }
        }
    }
}
