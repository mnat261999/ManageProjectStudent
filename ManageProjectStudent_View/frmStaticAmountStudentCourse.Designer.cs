namespace ManageProjectStudent_View
{
    partial class frmStaticAmountStudentCourse
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.amoutStudentofCourseTableAdapter = new ManageProjectStudent_View.DBManageProjectStudentDataSetTableAdapters.AmoutStudentofCourseTableAdapter();
            this.amoutStudentofCourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBManageProjectStudentDataSet = new ManageProjectStudent_View.DBManageProjectStudentDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amoutStudentofCourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBManageProjectStudentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataAdapter = this.amoutStudentofCourseTableAdapter;
            this.chartControl1.DataSource = this.amoutStudentofCourseBindingSource;
            xyDiagram1.AxisX.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            xyDiagram1.AxisX.Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisX.Thickness = 6;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            xyDiagram1.AxisY.Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xyDiagram1.AxisY.Thickness = 6;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chartControl1.Legend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "KhoaHoc";
            series1.Name = "Sinh viên";
            series1.ValueDataMembersSerializable = "AmoutStudent";
            sideBySideBarSeriesView1.BarWidth = 0.1D;
            sideBySideBarSeriesView1.Color = System.Drawing.Color.DarkMagenta;
            sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid;
            series1.View = sideBySideBarSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(843, 491);
            this.chartControl1.TabIndex = 0;
            chartTitle1.Text = "";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // amoutStudentofCourseTableAdapter
            // 
            this.amoutStudentofCourseTableAdapter.ClearBeforeFill = true;
            // 
            // amoutStudentofCourseBindingSource
            // 
            this.amoutStudentofCourseBindingSource.DataMember = "AmoutStudentofCourse";
            this.amoutStudentofCourseBindingSource.DataSource = this.dBManageProjectStudentDataSet;
            // 
            // dBManageProjectStudentDataSet
            // 
            this.dBManageProjectStudentDataSet.DataSetName = "DBManageProjectStudentDataSet";
            this.dBManageProjectStudentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmStaticAmountStudentCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 491);
            this.Controls.Add(this.chartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStaticAmountStudentCourse";
            this.Text = "frmStaticAmountStudentCourse";
            this.Load += new System.EventHandler(this.frmStaticAmountStudentCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amoutStudentofCourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBManageProjectStudentDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DBManageProjectStudentDataSetTableAdapters.AmoutStudentofCourseTableAdapter amoutStudentofCourseTableAdapter;
        private DBManageProjectStudentDataSet dBManageProjectStudentDataSet;
        private System.Windows.Forms.BindingSource amoutStudentofCourseBindingSource;
    }
}