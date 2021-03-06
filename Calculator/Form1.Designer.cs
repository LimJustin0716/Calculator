
namespace Calculator
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
            this.displaybox = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.clear_entry = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.plus_minus = new System.Windows.Forms.Button();
            this.rootsymbol = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.division_sym = new System.Windows.Forms.Button();
            this.percent_sign = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.multiplication_sym = new System.Windows.Forms.Button();
            this.reciprocal_func = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.subtraction_sym = new System.Windows.Forms.Button();
            this.equal_sym = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.dot_sym = new System.Windows.Forms.Button();
            this.addition_sym = new System.Windows.Forms.Button();
            this.natural_log = new System.Windows.Forms.Button();
            this.hyperbolic_sine = new System.Windows.Forms.Button();
            this.sine = new System.Windows.Forms.Button();
            this.squared_value = new System.Windows.Forms.Button();
            this.factorial_func = new System.Windows.Forms.Button();
            this.hyperbolic_cos = new System.Windows.Forms.Button();
            this.cosine = new System.Windows.Forms.Button();
            this.cube_root = new System.Windows.Forms.Button();
            this.hyperbolic_tan = new System.Windows.Forms.Button();
            this.tangent = new System.Windows.Forms.Button();
            this.cubed_value = new System.Windows.Forms.Button();
            this.square_root = new System.Windows.Forms.Button();
            this.exponential = new System.Windows.Forms.Button();
            this.modulus = new System.Windows.Forms.Button();
            this.logarithm = new System.Windows.Forms.Button();
            this.ten_raised_to_x = new System.Windows.Forms.Button();
            this.CalcuMenu = new System.Windows.Forms.MenuStrip();
            this.view_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitGroupingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateCalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worksheetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empty1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empty2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.lblShowOperation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pi_sym = new System.Windows.Forms.Button();
            this.CalcuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // displaybox
            // 
            this.displaybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaybox.Location = new System.Drawing.Point(16, 65);
            this.displaybox.Margin = new System.Windows.Forms.Padding(4);
            this.displaybox.Name = "displaybox";
            this.displaybox.Size = new System.Drawing.Size(518, 53);
            this.displaybox.TabIndex = 1;
            this.displaybox.Text = "0";
            this.displaybox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(246, 129);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(59, 44);
            this.backbtn.TabIndex = 6;
            this.backbtn.Text = "←";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // clear_entry
            // 
            this.clear_entry.Location = new System.Drawing.Point(303, 129);
            this.clear_entry.Margin = new System.Windows.Forms.Padding(4);
            this.clear_entry.Name = "clear_entry";
            this.clear_entry.Size = new System.Drawing.Size(59, 44);
            this.clear_entry.TabIndex = 7;
            this.clear_entry.Text = "CE";
            this.clear_entry.UseVisualStyleBackColor = true;
            this.clear_entry.Click += new System.EventHandler(this.clear_entry_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(360, 129);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(59, 44);
            this.clear.TabIndex = 8;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // plus_minus
            // 
            this.plus_minus.Location = new System.Drawing.Point(418, 129);
            this.plus_minus.Margin = new System.Windows.Forms.Padding(4);
            this.plus_minus.Name = "plus_minus";
            this.plus_minus.Size = new System.Drawing.Size(59, 44);
            this.plus_minus.TabIndex = 9;
            this.plus_minus.Text = "±";
            this.plus_minus.UseVisualStyleBackColor = true;
            this.plus_minus.Click += new System.EventHandler(this.plus_minus_click);
            // 
            // rootsymbol
            // 
            this.rootsymbol.Location = new System.Drawing.Point(475, 129);
            this.rootsymbol.Margin = new System.Windows.Forms.Padding(4);
            this.rootsymbol.Name = "rootsymbol";
            this.rootsymbol.Size = new System.Drawing.Size(59, 44);
            this.rootsymbol.TabIndex = 10;
            this.rootsymbol.Text = "√";
            this.rootsymbol.UseVisualStyleBackColor = true;
            this.rootsymbol.Click += new System.EventHandler(this.root_sym_click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(246, 172);
            this.num7.Margin = new System.Windows.Forms.Padding(4);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(59, 44);
            this.num7.TabIndex = 11;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.btn_num_dot);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(303, 172);
            this.num8.Margin = new System.Windows.Forms.Padding(4);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(59, 44);
            this.num8.TabIndex = 12;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.btn_num_dot);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(360, 172);
            this.num9.Margin = new System.Windows.Forms.Padding(4);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(59, 44);
            this.num9.TabIndex = 13;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.btn_num_dot);
            // 
            // division_sym
            // 
            this.division_sym.Location = new System.Drawing.Point(418, 172);
            this.division_sym.Margin = new System.Windows.Forms.Padding(4);
            this.division_sym.Name = "division_sym";
            this.division_sym.Size = new System.Drawing.Size(59, 44);
            this.division_sym.TabIndex = 14;
            this.division_sym.Text = "/";
            this.division_sym.UseVisualStyleBackColor = true;
            this.division_sym.Click += new System.EventHandler(this.Arithmetic_exp_mod);
            // 
            // percent_sign
            // 
            this.percent_sign.Location = new System.Drawing.Point(475, 172);
            this.percent_sign.Margin = new System.Windows.Forms.Padding(4);
            this.percent_sign.Name = "percent_sign";
            this.percent_sign.Size = new System.Drawing.Size(59, 44);
            this.percent_sign.TabIndex = 15;
            this.percent_sign.Text = "%";
            this.percent_sign.UseVisualStyleBackColor = true;
            this.percent_sign.Click += new System.EventHandler(this.percent_sym_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(246, 215);
            this.num4.Margin = new System.Windows.Forms.Padding(4);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(59, 44);
            this.num4.TabIndex = 16;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.btn_num_dot);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(303, 215);
            this.num5.Margin = new System.Windows.Forms.Padding(4);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(59, 44);
            this.num5.TabIndex = 17;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.btn_num_dot);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(360, 215);
            this.num6.Margin = new System.Windows.Forms.Padding(4);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(59, 44);
            this.num6.TabIndex = 18;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.btn_num_dot);
            // 
            // multiplication_sym
            // 
            this.multiplication_sym.Location = new System.Drawing.Point(418, 215);
            this.multiplication_sym.Margin = new System.Windows.Forms.Padding(4);
            this.multiplication_sym.Name = "multiplication_sym";
            this.multiplication_sym.Size = new System.Drawing.Size(59, 44);
            this.multiplication_sym.TabIndex = 19;
            this.multiplication_sym.Text = "*";
            this.multiplication_sym.UseVisualStyleBackColor = true;
            this.multiplication_sym.Click += new System.EventHandler(this.Arithmetic_exp_mod);
            // 
            // reciprocal_func
            // 
            this.reciprocal_func.Location = new System.Drawing.Point(475, 215);
            this.reciprocal_func.Margin = new System.Windows.Forms.Padding(4);
            this.reciprocal_func.Name = "reciprocal_func";
            this.reciprocal_func.Size = new System.Drawing.Size(59, 44);
            this.reciprocal_func.TabIndex = 20;
            this.reciprocal_func.Text = "1/x";
            this.reciprocal_func.UseVisualStyleBackColor = true;
            this.reciprocal_func.Click += new System.EventHandler(this.reciprocal_click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(246, 258);
            this.num1.Margin = new System.Windows.Forms.Padding(4);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(59, 44);
            this.num1.TabIndex = 21;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.btn_num_dot);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(303, 258);
            this.num2.Margin = new System.Windows.Forms.Padding(4);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(59, 44);
            this.num2.TabIndex = 22;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.btn_num_dot);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(360, 258);
            this.num3.Margin = new System.Windows.Forms.Padding(4);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(59, 44);
            this.num3.TabIndex = 23;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.btn_num_dot);
            // 
            // subtraction_sym
            // 
            this.subtraction_sym.Location = new System.Drawing.Point(418, 258);
            this.subtraction_sym.Margin = new System.Windows.Forms.Padding(4);
            this.subtraction_sym.Name = "subtraction_sym";
            this.subtraction_sym.Size = new System.Drawing.Size(59, 44);
            this.subtraction_sym.TabIndex = 24;
            this.subtraction_sym.Text = "-";
            this.subtraction_sym.UseVisualStyleBackColor = true;
            this.subtraction_sym.Click += new System.EventHandler(this.Arithmetic_exp_mod);
            // 
            // equal_sym
            // 
            this.equal_sym.Location = new System.Drawing.Point(475, 258);
            this.equal_sym.Margin = new System.Windows.Forms.Padding(4);
            this.equal_sym.Name = "equal_sym";
            this.equal_sym.Size = new System.Drawing.Size(59, 87);
            this.equal_sym.TabIndex = 25;
            this.equal_sym.Text = "=";
            this.equal_sym.UseVisualStyleBackColor = true;
            this.equal_sym.Click += new System.EventHandler(this.equal_sym_Click);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(246, 301);
            this.num0.Margin = new System.Windows.Forms.Padding(4);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(59, 44);
            this.num0.TabIndex = 26;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.btn_num_dot);
            // 
            // dot_sym
            // 
            this.dot_sym.Location = new System.Drawing.Point(360, 301);
            this.dot_sym.Margin = new System.Windows.Forms.Padding(4);
            this.dot_sym.Name = "dot_sym";
            this.dot_sym.Size = new System.Drawing.Size(59, 44);
            this.dot_sym.TabIndex = 27;
            this.dot_sym.Text = ".";
            this.dot_sym.UseVisualStyleBackColor = true;
            this.dot_sym.Click += new System.EventHandler(this.btn_num_dot);
            // 
            // addition_sym
            // 
            this.addition_sym.Location = new System.Drawing.Point(418, 301);
            this.addition_sym.Margin = new System.Windows.Forms.Padding(4);
            this.addition_sym.Name = "addition_sym";
            this.addition_sym.Size = new System.Drawing.Size(59, 44);
            this.addition_sym.TabIndex = 28;
            this.addition_sym.Text = "+";
            this.addition_sym.UseVisualStyleBackColor = true;
            this.addition_sym.Click += new System.EventHandler(this.Arithmetic_exp_mod);
            // 
            // natural_log
            // 
            this.natural_log.Location = new System.Drawing.Point(131, 215);
            this.natural_log.Margin = new System.Windows.Forms.Padding(4);
            this.natural_log.Name = "natural_log";
            this.natural_log.Size = new System.Drawing.Size(59, 44);
            this.natural_log.TabIndex = 34;
            this.natural_log.Text = "ln";
            this.natural_log.UseVisualStyleBackColor = true;
            this.natural_log.Click += new System.EventHandler(this.ln_click);
            // 
            // hyperbolic_sine
            // 
            this.hyperbolic_sine.Location = new System.Drawing.Point(16, 172);
            this.hyperbolic_sine.Margin = new System.Windows.Forms.Padding(4);
            this.hyperbolic_sine.Name = "hyperbolic_sine";
            this.hyperbolic_sine.Size = new System.Drawing.Size(59, 44);
            this.hyperbolic_sine.TabIndex = 38;
            this.hyperbolic_sine.Text = "sinh";
            this.hyperbolic_sine.UseVisualStyleBackColor = true;
            this.hyperbolic_sine.Click += new System.EventHandler(this.sinh_click);
            // 
            // sine
            // 
            this.sine.Location = new System.Drawing.Point(74, 172);
            this.sine.Margin = new System.Windows.Forms.Padding(4);
            this.sine.Name = "sine";
            this.sine.Size = new System.Drawing.Size(59, 44);
            this.sine.TabIndex = 39;
            this.sine.Text = "sin";
            this.sine.UseVisualStyleBackColor = true;
            this.sine.Click += new System.EventHandler(this.sin_click);
            // 
            // squared_value
            // 
            this.squared_value.Location = new System.Drawing.Point(131, 172);
            this.squared_value.Margin = new System.Windows.Forms.Padding(4);
            this.squared_value.Name = "squared_value";
            this.squared_value.Size = new System.Drawing.Size(59, 44);
            this.squared_value.TabIndex = 40;
            this.squared_value.Text = "x²";
            this.squared_value.UseVisualStyleBackColor = true;
            this.squared_value.Click += new System.EventHandler(this.squared_click);
            // 
            // factorial_func
            // 
            this.factorial_func.Location = new System.Drawing.Point(188, 172);
            this.factorial_func.Margin = new System.Windows.Forms.Padding(4);
            this.factorial_func.Name = "factorial_func";
            this.factorial_func.Size = new System.Drawing.Size(59, 44);
            this.factorial_func.TabIndex = 41;
            this.factorial_func.Text = "n!";
            this.factorial_func.UseVisualStyleBackColor = true;
            this.factorial_func.Click += new System.EventHandler(this.factorial_Click);
            // 
            // hyperbolic_cos
            // 
            this.hyperbolic_cos.Location = new System.Drawing.Point(16, 215);
            this.hyperbolic_cos.Margin = new System.Windows.Forms.Padding(4);
            this.hyperbolic_cos.Name = "hyperbolic_cos";
            this.hyperbolic_cos.Size = new System.Drawing.Size(59, 44);
            this.hyperbolic_cos.TabIndex = 43;
            this.hyperbolic_cos.Text = "cosh";
            this.hyperbolic_cos.UseVisualStyleBackColor = true;
            this.hyperbolic_cos.Click += new System.EventHandler(this.cosh_click);
            // 
            // cosine
            // 
            this.cosine.Location = new System.Drawing.Point(74, 215);
            this.cosine.Margin = new System.Windows.Forms.Padding(4);
            this.cosine.Name = "cosine";
            this.cosine.Size = new System.Drawing.Size(59, 44);
            this.cosine.TabIndex = 44;
            this.cosine.Text = "cos";
            this.cosine.UseVisualStyleBackColor = true;
            this.cosine.Click += new System.EventHandler(this.cos_click);
            // 
            // cube_root
            // 
            this.cube_root.Location = new System.Drawing.Point(188, 215);
            this.cube_root.Margin = new System.Windows.Forms.Padding(4);
            this.cube_root.Name = "cube_root";
            this.cube_root.Size = new System.Drawing.Size(59, 44);
            this.cube_root.TabIndex = 46;
            this.cube_root.Text = "³√x";
            this.cube_root.UseVisualStyleBackColor = true;
            this.cube_root.Click += new System.EventHandler(this.cube_root_click);
            // 
            // hyperbolic_tan
            // 
            this.hyperbolic_tan.Location = new System.Drawing.Point(16, 258);
            this.hyperbolic_tan.Margin = new System.Windows.Forms.Padding(4);
            this.hyperbolic_tan.Name = "hyperbolic_tan";
            this.hyperbolic_tan.Size = new System.Drawing.Size(59, 44);
            this.hyperbolic_tan.TabIndex = 48;
            this.hyperbolic_tan.Text = "tanh";
            this.hyperbolic_tan.UseVisualStyleBackColor = true;
            this.hyperbolic_tan.Click += new System.EventHandler(this.tanh_click);
            // 
            // tangent
            // 
            this.tangent.Location = new System.Drawing.Point(74, 258);
            this.tangent.Margin = new System.Windows.Forms.Padding(4);
            this.tangent.Name = "tangent";
            this.tangent.Size = new System.Drawing.Size(59, 44);
            this.tangent.TabIndex = 49;
            this.tangent.Text = "tan";
            this.tangent.UseVisualStyleBackColor = true;
            this.tangent.Click += new System.EventHandler(this.tan_click);
            // 
            // cubed_value
            // 
            this.cubed_value.Location = new System.Drawing.Point(131, 258);
            this.cubed_value.Margin = new System.Windows.Forms.Padding(4);
            this.cubed_value.Name = "cubed_value";
            this.cubed_value.Size = new System.Drawing.Size(59, 44);
            this.cubed_value.TabIndex = 50;
            this.cubed_value.Text = "x³";
            this.cubed_value.UseVisualStyleBackColor = true;
            this.cubed_value.Click += new System.EventHandler(this.cubed_click);
            // 
            // square_root
            // 
            this.square_root.Location = new System.Drawing.Point(188, 258);
            this.square_root.Margin = new System.Windows.Forms.Padding(4);
            this.square_root.Name = "square_root";
            this.square_root.Size = new System.Drawing.Size(59, 44);
            this.square_root.TabIndex = 51;
            this.square_root.Text = "²√x";
            this.square_root.UseVisualStyleBackColor = true;
            this.square_root.Click += new System.EventHandler(this.square_root_click);
            // 
            // exponential
            // 
            this.exponential.Location = new System.Drawing.Point(16, 301);
            this.exponential.Margin = new System.Windows.Forms.Padding(4);
            this.exponential.Name = "exponential";
            this.exponential.Size = new System.Drawing.Size(59, 44);
            this.exponential.TabIndex = 53;
            this.exponential.Text = "Exp";
            this.exponential.UseVisualStyleBackColor = true;
            this.exponential.Click += new System.EventHandler(this.Arithmetic_exp_mod);
            // 
            // modulus
            // 
            this.modulus.Location = new System.Drawing.Point(74, 301);
            this.modulus.Margin = new System.Windows.Forms.Padding(4);
            this.modulus.Name = "modulus";
            this.modulus.Size = new System.Drawing.Size(59, 44);
            this.modulus.TabIndex = 54;
            this.modulus.Text = "Mod";
            this.modulus.UseVisualStyleBackColor = true;
            this.modulus.Click += new System.EventHandler(this.Arithmetic_exp_mod);
            // 
            // logarithm
            // 
            this.logarithm.Location = new System.Drawing.Point(131, 301);
            this.logarithm.Margin = new System.Windows.Forms.Padding(4);
            this.logarithm.Name = "logarithm";
            this.logarithm.Size = new System.Drawing.Size(59, 44);
            this.logarithm.TabIndex = 55;
            this.logarithm.Text = "Log";
            this.logarithm.UseVisualStyleBackColor = true;
            this.logarithm.Click += new System.EventHandler(this.log_click);
            // 
            // ten_raised_to_x
            // 
            this.ten_raised_to_x.Location = new System.Drawing.Point(188, 301);
            this.ten_raised_to_x.Margin = new System.Windows.Forms.Padding(4);
            this.ten_raised_to_x.Name = "ten_raised_to_x";
            this.ten_raised_to_x.Size = new System.Drawing.Size(59, 44);
            this.ten_raised_to_x.TabIndex = 56;
            this.ten_raised_to_x.Text = "10^x";
            this.ten_raised_to_x.UseVisualStyleBackColor = true;
            this.ten_raised_to_x.Click += new System.EventHandler(this.ten_raised_to_x_Click);
            // 
            // CalcuMenu
            // 
            this.CalcuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CalcuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.view_menu,
            this.edit_menu,
            this.help_menu});
            this.CalcuMenu.Location = new System.Drawing.Point(0, 0);
            this.CalcuMenu.Name = "CalcuMenu";
            this.CalcuMenu.Size = new System.Drawing.Size(535, 28);
            this.CalcuMenu.TabIndex = 57;
            this.CalcuMenu.Text = "menuStrip1";
            // 
            // view_menu
            // 
            this.view_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.programmerToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.toolStripSeparator1,
            this.historyToolStripMenuItem,
            this.digitGroupingToolStripMenuItem,
            this.toolStripSeparator2,
            this.basicToolStripMenuItem,
            this.unitConversionToolStripMenuItem,
            this.dateCalculationToolStripMenuItem,
            this.worksheetsToolStripMenuItem});
            this.view_menu.Name = "view_menu";
            this.view_menu.Size = new System.Drawing.Size(55, 26);
            this.view_menu.Tag = "";
            this.view_menu.Text = "&View";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.standardToolStripMenuItem.Text = "Standard";
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.scientificToolStripMenuItem.Text = "Scientific";
            // 
            // programmerToolStripMenuItem
            // 
            this.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem";
            this.programmerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.programmerToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.programmerToolStripMenuItem.Text = "Programmer";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(252, 6);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.historyToolStripMenuItem.Text = "&History";
            // 
            // digitGroupingToolStripMenuItem
            // 
            this.digitGroupingToolStripMenuItem.Name = "digitGroupingToolStripMenuItem";
            this.digitGroupingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.digitGroupingToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.digitGroupingToolStripMenuItem.Text = "Digit &Grouping";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(252, 6);
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.basicToolStripMenuItem.Text = "&Basic";
            // 
            // unitConversionToolStripMenuItem
            // 
            this.unitConversionToolStripMenuItem.Name = "unitConversionToolStripMenuItem";
            this.unitConversionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.unitConversionToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.unitConversionToolStripMenuItem.Text = "&Unit Conversion";
            // 
            // dateCalculationToolStripMenuItem
            // 
            this.dateCalculationToolStripMenuItem.Name = "dateCalculationToolStripMenuItem";
            this.dateCalculationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dateCalculationToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.dateCalculationToolStripMenuItem.Text = "&Date Calculation";
            // 
            // worksheetsToolStripMenuItem
            // 
            this.worksheetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empty1ToolStripMenuItem,
            this.empty2ToolStripMenuItem});
            this.worksheetsToolStripMenuItem.Name = "worksheetsToolStripMenuItem";
            this.worksheetsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.worksheetsToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.worksheetsToolStripMenuItem.Text = "W&orksheets";
            // 
            // empty1ToolStripMenuItem
            // 
            this.empty1ToolStripMenuItem.Name = "empty1ToolStripMenuItem";
            this.empty1ToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.empty1ToolStripMenuItem.Text = "Empty1";
            // 
            // empty2ToolStripMenuItem
            // 
            this.empty2ToolStripMenuItem.Name = "empty2ToolStripMenuItem";
            this.empty2ToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.empty2ToolStripMenuItem.Text = "Empty2";
            // 
            // edit_menu
            // 
            this.edit_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.edit_menu.Name = "edit_menu";
            this.edit_menu.Size = new System.Drawing.Size(49, 26);
            this.edit_menu.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // help_menu
            // 
            this.help_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About});
            this.help_menu.Name = "help_menu";
            this.help_menu.Size = new System.Drawing.Size(55, 26);
            this.help_menu.Text = "&Help";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(133, 26);
            this.About.Text = "About";
            // 
            // lblShowOperation
            // 
            this.lblShowOperation.AutoSize = true;
            this.lblShowOperation.BackColor = System.Drawing.SystemColors.Window;
            this.lblShowOperation.Location = new System.Drawing.Point(32, 73);
            this.lblShowOperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowOperation.Name = "lblShowOperation";
            this.lblShowOperation.Size = new System.Drawing.Size(0, 17);
            this.lblShowOperation.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Scientific Calculator";
            // 
            // pi_sym
            // 
            this.pi_sym.Location = new System.Drawing.Point(303, 301);
            this.pi_sym.Margin = new System.Windows.Forms.Padding(4);
            this.pi_sym.Name = "pi_sym";
            this.pi_sym.Size = new System.Drawing.Size(59, 44);
            this.pi_sym.TabIndex = 47;
            this.pi_sym.Text = "π";
            this.pi_sym.UseVisualStyleBackColor = true;
            this.pi_sym.Click += new System.EventHandler(this.pi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(535, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblShowOperation);
            this.Controls.Add(this.ten_raised_to_x);
            this.Controls.Add(this.logarithm);
            this.Controls.Add(this.modulus);
            this.Controls.Add(this.exponential);
            this.Controls.Add(this.square_root);
            this.Controls.Add(this.cubed_value);
            this.Controls.Add(this.tangent);
            this.Controls.Add(this.hyperbolic_tan);
            this.Controls.Add(this.pi_sym);
            this.Controls.Add(this.cube_root);
            this.Controls.Add(this.cosine);
            this.Controls.Add(this.hyperbolic_cos);
            this.Controls.Add(this.factorial_func);
            this.Controls.Add(this.squared_value);
            this.Controls.Add(this.sine);
            this.Controls.Add(this.hyperbolic_sine);
            this.Controls.Add(this.natural_log);
            this.Controls.Add(this.addition_sym);
            this.Controls.Add(this.dot_sym);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.equal_sym);
            this.Controls.Add(this.subtraction_sym);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.reciprocal_func);
            this.Controls.Add(this.multiplication_sym);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.percent_sign);
            this.Controls.Add(this.division_sym);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.rootsymbol);
            this.Controls.Add(this.plus_minus);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.clear_entry);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.displaybox);
            this.Controls.Add(this.CalcuMenu);
            this.MainMenuStrip = this.CalcuMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " Calculator";
            this.CalcuMenu.ResumeLayout(false);
            this.CalcuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox displaybox;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button clear_entry;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button plus_minus;
        private System.Windows.Forms.Button rootsymbol;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button division_sym;
        private System.Windows.Forms.Button percent_sign;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button multiplication_sym;
        private System.Windows.Forms.Button reciprocal_func;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button subtraction_sym;
        private System.Windows.Forms.Button equal_sym;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button dot_sym;
        private System.Windows.Forms.Button addition_sym;
        private System.Windows.Forms.Button natural_log;
        private System.Windows.Forms.Button hyperbolic_sine;
        private System.Windows.Forms.Button sine;
        private System.Windows.Forms.Button squared_value;
        private System.Windows.Forms.Button factorial_func;
        private System.Windows.Forms.Button hyperbolic_cos;
        private System.Windows.Forms.Button cosine;
        private System.Windows.Forms.Button cube_root;
        private System.Windows.Forms.Button hyperbolic_tan;
        private System.Windows.Forms.Button tangent;
        private System.Windows.Forms.Button cubed_value;
        private System.Windows.Forms.Button square_root;
        private System.Windows.Forms.Button exponential;
        private System.Windows.Forms.Button modulus;
        private System.Windows.Forms.Button logarithm;
        private System.Windows.Forms.Button ten_raised_to_x;
        private System.Windows.Forms.MenuStrip CalcuMenu;
        private System.Windows.Forms.ToolStripMenuItem view_menu;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edit_menu;
        private System.Windows.Forms.ToolStripMenuItem help_menu;
        private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitGroupingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitConversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateCalculationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worksheetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empty1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empty2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.Label lblShowOperation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pi_sym;
    }
}

