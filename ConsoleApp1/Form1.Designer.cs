namespace ConsoleApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.instructorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.instructorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timetableDBDataSet = new ConsoleApp1.TimetableDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.instructorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.instructorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timetableDBDataSet11 = new ConsoleApp1.TimetableDBDataSet1();
            this.instructorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.instructorsTableAdapter1 = new ConsoleApp1.TimetableDBDataSet1TableAdapters.InstructorsTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.instructorsTableAdapter = new ConsoleApp1.TimetableDBDataSetTableAdapters.InstructorsTableAdapter();
            this.tableAdapterManager = new ConsoleApp1.TimetableDBDataSetTableAdapters.TableAdapterManager();
            this.timetableDBDataSet1 = new ConsoleApp1.TimetableDBDataSet();
            this.timetableDBDataSet2 = new ConsoleApp1.TimetableDBDataSet();
            this.timetableDBDataSet3 = new ConsoleApp1.TimetableDBDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timetableDBDataSet21 = new ConsoleApp1.TimetableDBDataSet2();
            this.iTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTTableAdapter = new ConsoleApp1.TimetableDBDataSet2TableAdapters.ITTableAdapter();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingNavigator)).BeginInit();
            this.instructorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // instructorsBindingNavigator
            // 
            this.instructorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.instructorsBindingNavigator.BindingSource = this.instructorsBindingSource;
            this.instructorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.instructorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.instructorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.instructorsBindingNavigatorSaveItem});
            this.instructorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.instructorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.instructorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.instructorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.instructorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.instructorsBindingNavigator.Name = "instructorsBindingNavigator";
            this.instructorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.instructorsBindingNavigator.Size = new System.Drawing.Size(525, 25);
            this.instructorsBindingNavigator.TabIndex = 0;
            this.instructorsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // instructorsBindingSource
            // 
            this.instructorsBindingSource.DataMember = "Instructors";
            this.instructorsBindingSource.DataSource = this.timetableDBDataSet;
            // 
            // timetableDBDataSet
            // 
            this.timetableDBDataSet.DataSetName = "TimetableDBDataSet";
            this.timetableDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // instructorsBindingNavigatorSaveItem
            // 
            this.instructorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.instructorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("instructorsBindingNavigatorSaveItem.Image")));
            this.instructorsBindingNavigatorSaveItem.Name = "instructorsBindingNavigatorSaveItem";
            this.instructorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.instructorsBindingNavigatorSaveItem.Text = "Save Data";
            this.instructorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.instructorsBindingNavigatorSaveItem_Click);
            // 
            // instructorsDataGridView
            // 
            this.instructorsDataGridView.AutoGenerateColumns = false;
            this.instructorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.instructorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.instructorsDataGridView.DataSource = this.instructorsBindingSource;
            this.instructorsDataGridView.Location = new System.Drawing.Point(12, 53);
            this.instructorsDataGridView.Name = "instructorsDataGridView";
            this.instructorsDataGridView.Size = new System.Drawing.Size(229, 183);
            this.instructorsDataGridView.TabIndex = 1;
            this.instructorsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.instructorsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // timetableDBDataSet11
            // 
            this.timetableDBDataSet11.DataSetName = "TimetableDBDataSet1";
            this.timetableDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instructorsBindingSource1
            // 
            this.instructorsBindingSource1.DataMember = "Instructors";
            this.instructorsBindingSource1.DataSource = this.timetableDBDataSet11;
            // 
            // instructorsTableAdapter1
            // 
            this.instructorsTableAdapter1.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(525, 25);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // instructorsTableAdapter
            // 
            this.instructorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseClassTableAdapter = null;
            this.tableAdapterManager.CourseClassYDTableAdapter = null;
            this.tableAdapterManager.CoursesTableAdapter = null;
            this.tableAdapterManager.CSTableAdapter = null;
            this.tableAdapterManager.CurriculumCoursesTableAdapter = null;
            this.tableAdapterManager.CurriculumDevisionsTableAdapter = null;
            this.tableAdapterManager.CurriculumTableAdapter = null;
            this.tableAdapterManager.InstructorClassesTableAdapter = null;
            this.tableAdapterManager.InstructorsTableAdapter = this.instructorsTableAdapter;
            this.tableAdapterManager.ITTableAdapter = null;
            this.tableAdapterManager.MathCSTableAdapter = null;
            this.tableAdapterManager.MathTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.STATCSTableAdapter = null;
            this.tableAdapterManager.STATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ConsoleApp1.TimetableDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timetableDBDataSet1
            // 
            this.timetableDBDataSet1.DataSetName = "TimetableDBDataSet";
            this.timetableDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timetableDBDataSet2
            // 
            this.timetableDBDataSet2.DataSetName = "TimetableDBDataSet";
            this.timetableDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timetableDBDataSet3
            // 
            this.timetableDBDataSet3.DataSetName = "TimetableDBDataSet";
            this.timetableDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(229, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // timetableDBDataSet21
            // 
            this.timetableDBDataSet21.DataSetName = "TimetableDBDataSet2";
            this.timetableDBDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTBindingSource
            // 
            this.iTBindingSource.DataMember = "IT";
            this.iTBindingSource.DataSource = this.timetableDBDataSet21;
            // 
            // iTTableAdapter
            // 
            this.iTTableAdapter.ClearBeforeFill = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 484);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.instructorsDataGridView);
            this.Controls.Add(this.instructorsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingNavigator)).EndInit();
            this.instructorsBindingNavigator.ResumeLayout(false);
            this.instructorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableDBDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TimetableDBDataSet timetableDBDataSet;
        private System.Windows.Forms.BindingSource instructorsBindingSource;
        private TimetableDBDataSetTableAdapters.InstructorsTableAdapter instructorsTableAdapter;
        private TimetableDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator instructorsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton instructorsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView instructorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private TimetableDBDataSet timetableDBDataSet1;
        private TimetableDBDataSet timetableDBDataSet2;
        private TimetableDBDataSet1 timetableDBDataSet11;
        private System.Windows.Forms.BindingSource instructorsBindingSource1;
        private TimetableDBDataSet1TableAdapters.InstructorsTableAdapter instructorsTableAdapter1;
        private TimetableDBDataSet timetableDBDataSet3;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TimetableDBDataSet2 timetableDBDataSet21;
        private System.Windows.Forms.BindingSource iTBindingSource;
        private TimetableDBDataSet2TableAdapters.ITTableAdapter iTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
    }
}