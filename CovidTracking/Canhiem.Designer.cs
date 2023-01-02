namespace CovidTracking
{
    partial class Canhiem
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
            DevExpress.DataAccess.Json.UriJsonSource uriJsonSource3 = new DevExpress.DataAccess.Json.UriJsonSource();
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode59 = new DevExpress.DataAccess.Json.JsonSchemaNode("root", true, DevExpress.DataAccess.Json.JsonNodeType.Array);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode60 = new DevExpress.DataAccess.Json.JsonSchemaNode("time", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode61 = new DevExpress.DataAccess.Json.JsonSchemaNode("total", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode62 = new DevExpress.DataAccess.Json.JsonSchemaNode("out_quarantine_area", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(object));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode63 = new DevExpress.DataAccess.Json.JsonSchemaNode("in_quarantine_area", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(object));
            DevExpress.XtraCharts.XYDiagram xyDiagram7 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series9 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series10 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView7 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode64 = new DevExpress.DataAccess.Json.JsonSchemaNode("root", true, DevExpress.DataAccess.Json.JsonNodeType.Array);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode65 = new DevExpress.DataAccess.Json.JsonSchemaNode("id", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode66 = new DevExpress.DataAccess.Json.JsonSchemaNode("name", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode67 = new DevExpress.DataAccess.Json.JsonSchemaNode("population", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode68 = new DevExpress.DataAccess.Json.JsonSchemaNode("new_case", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode69 = new DevExpress.DataAccess.Json.JsonSchemaNode("new_death", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode70 = new DevExpress.DataAccess.Json.JsonSchemaNode("new_recovered", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode71 = new DevExpress.DataAccess.Json.JsonSchemaNode("new_active", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode72 = new DevExpress.DataAccess.Json.JsonSchemaNode("total_case", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode73 = new DevExpress.DataAccess.Json.JsonSchemaNode("total_death", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode74 = new DevExpress.DataAccess.Json.JsonSchemaNode("total_active", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode75 = new DevExpress.DataAccess.Json.JsonSchemaNode("total_recovered", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode76 = new DevExpress.DataAccess.Json.JsonSchemaNode("death_yesterday", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode77 = new DevExpress.DataAccess.Json.JsonSchemaNode("case_yesterday", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode78 = new DevExpress.DataAccess.Json.JsonSchemaNode("recovered_yesterday", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode79 = new DevExpress.DataAccess.Json.JsonSchemaNode("death_average_7days", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode80 = new DevExpress.DataAccess.Json.JsonSchemaNode("case_average_7days", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode81 = new DevExpress.DataAccess.Json.JsonSchemaNode("percent_case_population", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<double>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode82 = new DevExpress.DataAccess.Json.JsonSchemaNode("last_updated", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.XtraCharts.XYDiagram xyDiagram8 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series11 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView8 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram9 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series12 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView9 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode83 = new DevExpress.DataAccess.Json.JsonSchemaNode("root", true, DevExpress.DataAccess.Json.JsonNodeType.Array);
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode84 = new DevExpress.DataAccess.Json.JsonSchemaNode("time", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode85 = new DevExpress.DataAccess.Json.JsonSchemaNode("total", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode86 = new DevExpress.DataAccess.Json.JsonSchemaNode("out_quarantine_area", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(object));
            DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode87 = new DevExpress.DataAccess.Json.JsonSchemaNode("in_quarantine_area", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(object));
            this.jsonDataSource2 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartControl3 = new DevExpress.XtraCharts.ChartControl();
            this.jsonDataSource3 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.jsonDataSource1 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView9)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jsonDataSource2
            // 
            this.jsonDataSource2.ConnectionName = "catuvongtheongay";
            uriJsonSource3.Uri = new System.Uri("C:\\Du\\catuvong (1).json", System.UriKind.Absolute);
            this.jsonDataSource2.JsonSource = uriJsonSource3;
            this.jsonDataSource2.Name = "jsonDataSource2";
            jsonSchemaNode59.Nodes.Add(jsonSchemaNode60);
            jsonSchemaNode59.Nodes.Add(jsonSchemaNode61);
            jsonSchemaNode59.Nodes.Add(jsonSchemaNode62);
            jsonSchemaNode59.Nodes.Add(jsonSchemaNode63);
            this.jsonDataSource2.Schema = jsonSchemaNode59;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chartControl3);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.chartControl2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.chartControl1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2681, 1389);
            this.panel1.TabIndex = 0;
            // 
            // chartControl3
            // 
            this.chartControl3.DataSource = this.jsonDataSource3;
            xyDiagram7.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram7.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl3.Diagram = xyDiagram7;
            this.chartControl3.Location = new System.Drawing.Point(87, 1417);
            this.chartControl3.Name = "chartControl3";
            series9.ArgumentDataMember = "name";
            series9.Name = "Tổng ca nhiễm";
            series9.ValueDataMembersSerializable = "total_case";
            series10.ArgumentDataMember = "name";
            series10.Name = "Tổng ca tử vong";
            series10.ValueDataMembersSerializable = "total_death";
            series10.View = lineSeriesView7;
            this.chartControl3.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series9,
        series10};
            this.chartControl3.Size = new System.Drawing.Size(2487, 1006);
            this.chartControl3.TabIndex = 25;
            // 
            // jsonDataSource3
            // 
            this.jsonDataSource3.ConnectionName = "catheotinh";
            this.jsonDataSource3.Name = "jsonDataSource3";
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode65);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode66);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode67);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode68);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode69);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode70);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode71);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode72);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode73);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode74);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode75);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode76);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode77);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode78);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode79);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode80);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode81);
            jsonSchemaNode64.Nodes.Add(jsonSchemaNode82);
            this.jsonDataSource3.Schema = jsonSchemaNode64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(96, 1329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(718, 52);
            this.label14.TabIndex = 24;
            this.label14.Text = "Biểu đồ so sánh theo tỉnh thành";
            // 
            // chartControl2
            // 
            this.chartControl2.DataSource = this.jsonDataSource2;
            xyDiagram8.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram8.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram8;
            this.chartControl2.Location = new System.Drawing.Point(1305, 670);
            this.chartControl2.Name = "chartControl2";
            series11.ArgumentDataMember = "time";
            series11.DataSource = this.jsonDataSource2;
            series11.Name = "Số ca tử vong";
            series11.ValueDataMembersSerializable = "total";
            series11.View = lineSeriesView8;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series11};
            this.chartControl2.Size = new System.Drawing.Size(1269, 607);
            this.chartControl2.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1312, 574);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(551, 52);
            this.label13.TabIndex = 22;
            this.label13.Text = "Số ca tử vong theo ngày";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(96, 574);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(518, 52);
            this.label12.TabIndex = 20;
            this.label12.Text = "Số ca nhiễm theo ngày";
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.jsonDataSource1;
            xyDiagram9.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram9.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram9;
            this.chartControl1.Location = new System.Drawing.Point(87, 670);
            this.chartControl1.Name = "chartControl1";
            series12.ArgumentDataMember = "time";
            series12.Name = "Số ca nhiễm";
            series12.ValueDataMembersSerializable = "total";
            series12.View = lineSeriesView9;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series12};
            this.chartControl1.Size = new System.Drawing.Size(1135, 607);
            this.chartControl1.TabIndex = 19;
            // 
            // jsonDataSource1
            // 
            this.jsonDataSource1.ConnectionName = "canhiemtheongay";
            this.jsonDataSource1.Name = "jsonDataSource1";
            jsonSchemaNode83.Nodes.Add(jsonSchemaNode84);
            jsonSchemaNode83.Nodes.Add(jsonSchemaNode85);
            jsonSchemaNode83.Nodes.Add(jsonSchemaNode86);
            jsonSchemaNode83.Nodes.Add(jsonSchemaNode87);
            this.jsonDataSource1.Schema = jsonSchemaNode83;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(2046, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(528, 228);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tổng đang điều trị";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Orange;
            this.label10.Location = new System.Drawing.Point(57, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 33);
            this.label10.TabIndex = 7;
            this.label10.Text = "+103 ngày qua";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Orange;
            this.label11.Location = new System.Drawing.Point(42, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 39);
            this.label11.TabIndex = 6;
            this.label11.Text = "78.917";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1351, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 228);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng ca hồi phục";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OliveDrab;
            this.label8.Location = new System.Drawing.Point(63, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 33);
            this.label8.TabIndex = 5;
            this.label8.Text = "+79 ngày qua";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OliveDrab;
            this.label9.Location = new System.Drawing.Point(48, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 39);
            this.label9.TabIndex = 4;
            this.label9.Text = "10.610.917";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(698, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 228);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng ca tử vong";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(61, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "+51 ngày qua";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(46, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 39);
            this.label7.TabIndex = 2;
            this.label7.Text = "43.184";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 228);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng ca nhiễm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(62, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "+211 ngày qua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(47, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "11.524.647";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(538, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "03/01/2023";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(52, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nguồn : Bộ Y tế. Cập nhật lần cuối :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thống kê ca nhiễm :   Toàn quốc";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(847, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 49);
            this.button5.TabIndex = 12;
            this.button5.Text = "Tin tức";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(641, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 49);
            this.button4.TabIndex = 11;
            this.button4.Text = "PC - Covid";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 49);
            this.button3.TabIndex = 10;
            this.button3.Text = "Tiêm chủng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 49);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ca nhiễm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tổng quan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Canhiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2681, 1389);
            this.Controls.Add(this.panel1);
            this.Name = "Canhiem";
            this.Text = "Canhiem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource2;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraCharts.ChartControl chartControl3;
        private System.Windows.Forms.Label label14;
        private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource3;
    }
}