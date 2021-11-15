namespace projekt1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button button17;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zaklaniKalkulackaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vedeckaKalkulackaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teplotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prevodJednotekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nasobeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastaveniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pohledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSpace = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.ButtonPercentage = new System.Windows.Forms.Button();
            this.ButtonPi = new System.Windows.Forms.Button();
            this.ButtonLnx = new System.Windows.Forms.Button();
            this.ButtonTan = new System.Windows.Forms.Button();
            this.Button1x = new System.Windows.Forms.Button();
            this.ButtonCos = new System.Windows.Forms.Button();
            this.ButtonX3 = new System.Windows.Forms.Button();
            this.ButtonSin = new System.Windows.Forms.Button();
            this.ButtonDouble2 = new System.Windows.Forms.Button();
            this.ButtonLog = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblShowOp = new System.Windows.Forms.Label();
            button17 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button17
            // 
            button17.BackColor = System.Drawing.SystemColors.ButtonShadow;
            button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            button17.Location = new System.Drawing.Point(230, 334);
            button17.Margin = new System.Windows.Forms.Padding(2);
            button17.Name = "button17";
            button17.Size = new System.Drawing.Size(69, 67);
            button17.TabIndex = 21;
            button17.Text = "÷";
            button17.UseVisualStyleBackColor = false;
            button17.Click += new System.EventHandler(this.AritmeticOperator);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.nastaveniToolStripMenuItem,
            this.pohledToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(482, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Click += new System.EventHandler(this.button_Click);
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaklaniKalkulackaToolStripMenuItem,
            this.vedeckaKalkulackaToolStripMenuItem,
            this.teplotaToolStripMenuItem,
            this.prevodJednotekToolStripMenuItem,
            this.nasobeniToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // zaklaniKalkulackaToolStripMenuItem
            // 
            this.zaklaniKalkulackaToolStripMenuItem.Name = "zaklaniKalkulackaToolStripMenuItem";
            this.zaklaniKalkulackaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.zaklaniKalkulackaToolStripMenuItem.Text = "Zaklani kalkulacka";
            this.zaklaniKalkulackaToolStripMenuItem.Click += new System.EventHandler(this.zaklaniKalkulackaToolStripMenuItem_Click);
            // 
            // vedeckaKalkulackaToolStripMenuItem
            // 
            this.vedeckaKalkulackaToolStripMenuItem.Name = "vedeckaKalkulackaToolStripMenuItem";
            this.vedeckaKalkulackaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.vedeckaKalkulackaToolStripMenuItem.Text = "Vedecka kalkulacka";
            this.vedeckaKalkulackaToolStripMenuItem.Click += new System.EventHandler(this.vedeckaKalkulackaToolStripMenuItem_Click);
            // 
            // teplotaToolStripMenuItem
            // 
            this.teplotaToolStripMenuItem.Name = "teplotaToolStripMenuItem";
            this.teplotaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            // 
            // prevodJednotekToolStripMenuItem
            // 
            this.prevodJednotekToolStripMenuItem.Name = "prevodJednotekToolStripMenuItem";
            this.prevodJednotekToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            // 
            // nasobeniToolStripMenuItem
            // 
            this.nasobeniToolStripMenuItem.Name = "nasobeniToolStripMenuItem";
            this.nasobeniToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            // 
            // nastaveniToolStripMenuItem
            // 
            this.nastaveniToolStripMenuItem.Name = "nastaveniToolStripMenuItem";
            this.nastaveniToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.nastaveniToolStripMenuItem.Text = "Nastaveni";
            // 
            // pohledToolStripMenuItem
            // 
            this.pohledToolStripMenuItem.Name = "pohledToolStripMenuItem";
            this.pohledToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.pohledToolStripMenuItem.Text = "Pohled";
            // 
            // buttonSpace
            // 
            this.buttonSpace.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSpace.Location = new System.Drawing.Point(11, 50);
            this.buttonSpace.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSpace.Name = "buttonSpace";
            this.buttonSpace.Size = new System.Drawing.Size(69, 67);
            this.buttonSpace.TabIndex = 1;
            this.buttonSpace.Text = "⌫";
            this.buttonSpace.UseVisualStyleBackColor = false;
            this.buttonSpace.Click += new System.EventHandler(this.buttonSpace_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(84, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 67);
            this.button2.TabIndex = 3;
            this.button2.Text = "CE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(157, 50);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 67);
            this.button3.TabIndex = 4;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.Location = new System.Drawing.Point(230, 50);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 67);
            this.button4.TabIndex = 5;
            this.button4.Text = "±";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(230, 121);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 67);
            this.button5.TabIndex = 9;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.AritmeticOperator);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(157, 121);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 67);
            this.button6.TabIndex = 8;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(84, 121);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 67);
            this.button7.TabIndex = 7;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(11, 121);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 67);
            this.button8.TabIndex = 6;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(230, 192);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 67);
            this.button9.TabIndex = 13;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.AritmeticOperator);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(157, 192);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(69, 67);
            this.button10.TabIndex = 12;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(84, 192);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(69, 67);
            this.button11.TabIndex = 11;
            this.button11.Text = "5";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.Location = new System.Drawing.Point(11, 192);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(69, 67);
            this.button12.TabIndex = 10;
            this.button12.Text = "4";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button13.Location = new System.Drawing.Point(230, 263);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(69, 67);
            this.button13.TabIndex = 17;
            this.button13.Text = "*";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.AritmeticOperator);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button14.Location = new System.Drawing.Point(157, 263);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(69, 67);
            this.button14.TabIndex = 16;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button15.Location = new System.Drawing.Point(84, 263);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(69, 67);
            this.button15.TabIndex = 15;
            this.button15.Text = "2";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button16.Location = new System.Drawing.Point(11, 263);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(69, 67);
            this.button16.TabIndex = 14;
            this.button16.Text = "1";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button18.Location = new System.Drawing.Point(157, 334);
            this.button18.Margin = new System.Windows.Forms.Padding(2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(69, 67);
            this.button18.TabIndex = 20;
            this.button18.Text = "=";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button19.Location = new System.Drawing.Point(84, 334);
            this.button19.Margin = new System.Windows.Forms.Padding(2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(69, 67);
            this.button19.TabIndex = 19;
            this.button19.Text = ".";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button20.Location = new System.Drawing.Point(11, 334);
            this.button20.Margin = new System.Windows.Forms.Padding(2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(69, 67);
            this.button20.TabIndex = 18;
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button_Click);
            // 
            // ButtonPercentage
            // 
            this.ButtonPercentage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPercentage.Location = new System.Drawing.Point(398, 333);
            this.ButtonPercentage.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPercentage.Name = "ButtonPercentage";
            this.ButtonPercentage.Size = new System.Drawing.Size(69, 67);
            this.ButtonPercentage.TabIndex = 41;
            this.ButtonPercentage.Text = "%";
            this.ButtonPercentage.UseVisualStyleBackColor = false;
            this.ButtonPercentage.Click += new System.EventHandler(this.ButtonPercentage_Click);
            // 
            // ButtonPi
            // 
            this.ButtonPi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPi.Location = new System.Drawing.Point(325, 333);
            this.ButtonPi.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPi.Name = "ButtonPi";
            this.ButtonPi.Size = new System.Drawing.Size(69, 67);
            this.ButtonPi.TabIndex = 40;
            this.ButtonPi.Text = "π";
            this.ButtonPi.UseVisualStyleBackColor = false;
            this.ButtonPi.Click += new System.EventHandler(this.ButtonPi_Click);
            // 
            // ButtonLnx
            // 
            this.ButtonLnx.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonLnx.Location = new System.Drawing.Point(398, 263);
            this.ButtonLnx.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonLnx.Name = "ButtonLnx";
            this.ButtonLnx.Size = new System.Drawing.Size(69, 67);
            this.ButtonLnx.TabIndex = 37;
            this.ButtonLnx.Text = "ln x";
            this.ButtonLnx.UseVisualStyleBackColor = false;
            this.ButtonLnx.Click += new System.EventHandler(this.ButtonLnx_Click);
            // 
            // ButtonTan
            // 
            this.ButtonTan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonTan.Location = new System.Drawing.Point(325, 262);
            this.ButtonTan.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonTan.Name = "ButtonTan";
            this.ButtonTan.Size = new System.Drawing.Size(69, 67);
            this.ButtonTan.TabIndex = 36;
            this.ButtonTan.Text = "Tan";
            this.ButtonTan.UseVisualStyleBackColor = false;
            this.ButtonTan.Click += new System.EventHandler(this.ButtonTan_Click);
            // 
            // Button1x
            // 
            this.Button1x.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Button1x.Location = new System.Drawing.Point(398, 192);
            this.Button1x.Margin = new System.Windows.Forms.Padding(2);
            this.Button1x.Name = "Button1x";
            this.Button1x.Size = new System.Drawing.Size(69, 67);
            this.Button1x.TabIndex = 33;
            this.Button1x.Text = "1/x";
            this.Button1x.UseVisualStyleBackColor = false;
            this.Button1x.Click += new System.EventHandler(this.Button1x_Click);
            // 
            // ButtonCos
            // 
            this.ButtonCos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonCos.Location = new System.Drawing.Point(325, 191);
            this.ButtonCos.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCos.Name = "ButtonCos";
            this.ButtonCos.Size = new System.Drawing.Size(69, 67);
            this.ButtonCos.TabIndex = 32;
            this.ButtonCos.Text = "Cos";
            this.ButtonCos.UseVisualStyleBackColor = false;
            this.ButtonCos.Click += new System.EventHandler(this.button30_Click);
            // 
            // ButtonX3
            // 
            this.ButtonX3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonX3.Location = new System.Drawing.Point(398, 121);
            this.ButtonX3.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonX3.Name = "ButtonX3";
            this.ButtonX3.Size = new System.Drawing.Size(69, 67);
            this.ButtonX3.TabIndex = 29;
            this.ButtonX3.Text = "x^3";
            this.ButtonX3.UseVisualStyleBackColor = false;
            this.ButtonX3.Click += new System.EventHandler(this.ButtonX3_Click);
            // 
            // ButtonSin
            // 
            this.ButtonSin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonSin.Location = new System.Drawing.Point(325, 120);
            this.ButtonSin.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSin.Name = "ButtonSin";
            this.ButtonSin.Size = new System.Drawing.Size(69, 67);
            this.ButtonSin.TabIndex = 28;
            this.ButtonSin.Text = "Sin";
            this.ButtonSin.UseVisualStyleBackColor = false;
            this.ButtonSin.Click += new System.EventHandler(this.ButtonSin_Click);
            // 
            // ButtonDouble2
            // 
            this.ButtonDouble2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonDouble2.Location = new System.Drawing.Point(398, 50);
            this.ButtonDouble2.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDouble2.Name = "ButtonDouble2";
            this.ButtonDouble2.Size = new System.Drawing.Size(69, 67);
            this.ButtonDouble2.TabIndex = 25;
            this.ButtonDouble2.Text = "x^2";
            this.ButtonDouble2.UseVisualStyleBackColor = false;
            this.ButtonDouble2.Click += new System.EventHandler(this.ButtonDouble2_Click);
            // 
            // ButtonLog
            // 
            this.ButtonLog.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ButtonLog.Location = new System.Drawing.Point(325, 50);
            this.ButtonLog.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonLog.Name = "ButtonLog";
            this.ButtonLog.Size = new System.Drawing.Size(69, 67);
            this.ButtonLog.TabIndex = 24;
            this.ButtonLog.Text = "Log";
            this.ButtonLog.UseVisualStyleBackColor = false;
            this.ButtonLog.Click += new System.EventHandler(this.ButtonLog_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(11, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblShowOp
            // 
            this.lblShowOp.AutoSize = true;
            this.lblShowOp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShowOp.Location = new System.Drawing.Point(20, 28);
            this.lblShowOp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowOp.Name = "lblShowOp";
            this.lblShowOp.Size = new System.Drawing.Size(0, 13);
            this.lblShowOp.TabIndex = 43;
            this.lblShowOp.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 424);
            this.Controls.Add(this.lblShowOp);
            this.Controls.Add(this.ButtonPercentage);
            this.Controls.Add(this.ButtonPi);
            this.Controls.Add(this.ButtonLnx);
            this.Controls.Add(this.ButtonTan);
            this.Controls.Add(this.Button1x);
            this.Controls.Add(this.ButtonCos);
            this.Controls.Add(this.ButtonX3);
            this.Controls.Add(this.ButtonSin);
            this.Controls.Add(this.ButtonDouble2);
            this.Controls.Add(this.ButtonLog);
            this.Controls.Add(button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSpace);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Kalkulacka App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonSpace;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button ButtonPercentage;
        private System.Windows.Forms.Button ButtonPi;
        private System.Windows.Forms.Button ButtonLnx;
        private System.Windows.Forms.Button ButtonTan;
        private System.Windows.Forms.Button Button1x;
        private System.Windows.Forms.Button ButtonCos;
        private System.Windows.Forms.Button ButtonX3;
        private System.Windows.Forms.Button ButtonSin;
        private System.Windows.Forms.Button ButtonDouble2;
        private System.Windows.Forms.Button ButtonLog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblShowOp;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zaklaniKalkulackaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vedeckaKalkulackaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teplotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prevodJednotekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nasobeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastaveniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pohledToolStripMenuItem;
    }
}

