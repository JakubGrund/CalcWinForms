namespace CalcWinFormsOprava
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakladniKalkulackaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vedeckaKalkulackaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonSpaceBack = new System.Windows.Forms.Button();
            this.ButtonC = new System.Windows.Forms.Button();
            this.ButtonPlusMinus = new System.Windows.Forms.Button();
            this.ButtonLog = new System.Windows.Forms.Button();
            this.ButtonX2 = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.ButtonNasobeni = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.ButtonDeleni = new System.Windows.Forms.Button();
            this.ButtonRovnase = new System.Windows.Forms.Button();
            this.ButtonTecka = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.ButtonX3 = new System.Windows.Forms.Button();
            this.ButtonSin = new System.Windows.Forms.Button();
            this.Button1X = new System.Windows.Forms.Button();
            this.ButtonCos = new System.Windows.Forms.Button();
            this.ButtonLnx = new System.Windows.Forms.Button();
            this.ButtonPercentage = new System.Windows.Forms.Button();
            this.ButtonPi = new System.Windows.Forms.Button();
            this.ButtonCE = new System.Windows.Forms.Button();
            this.ButtonTan = new System.Windows.Forms.Button();
            this.lblShowOp = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(493, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakladniKalkulackaToolStripMenuItem,
            this.vedeckaKalkulackaToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // zakladniKalkulackaToolStripMenuItem
            // 
            this.zakladniKalkulackaToolStripMenuItem.Name = "zakladniKalkulackaToolStripMenuItem";
            this.zakladniKalkulackaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.zakladniKalkulackaToolStripMenuItem.Text = "Zakladni Kalkulacka";
            this.zakladniKalkulackaToolStripMenuItem.Click += new System.EventHandler(this.zakladniKalkulackaToolStripMenuItem_Click);
            // 
            // vedeckaKalkulackaToolStripMenuItem
            // 
            this.vedeckaKalkulackaToolStripMenuItem.Name = "vedeckaKalkulackaToolStripMenuItem";
            this.vedeckaKalkulackaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.vedeckaKalkulackaToolStripMenuItem.Text = "Vedecka Kalkulacka";
            this.vedeckaKalkulackaToolStripMenuItem.Click += new System.EventHandler(this.vedeckaKalkulackaToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(467, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ButtonSpaceBack
            // 
            this.ButtonSpaceBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonSpaceBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonSpaceBack.Location = new System.Drawing.Point(12, 77);
            this.ButtonSpaceBack.Name = "ButtonSpaceBack";
            this.ButtonSpaceBack.Size = new System.Drawing.Size(68, 63);
            this.ButtonSpaceBack.TabIndex = 2;
            this.ButtonSpaceBack.Text = "⌫";
            this.ButtonSpaceBack.UseVisualStyleBackColor = false;
            this.ButtonSpaceBack.Click += new System.EventHandler(this.ButtonSpaceBack_Click_1);
            // 
            // ButtonC
            // 
            this.ButtonC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonC.Location = new System.Drawing.Point(160, 77);
            this.ButtonC.Name = "ButtonC";
            this.ButtonC.Size = new System.Drawing.Size(68, 63);
            this.ButtonC.TabIndex = 4;
            this.ButtonC.Text = "C";
            this.ButtonC.UseVisualStyleBackColor = false;
            this.ButtonC.Click += new System.EventHandler(this.ButtonC_Click);
            // 
            // ButtonPlusMinus
            // 
            this.ButtonPlusMinus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPlusMinus.Location = new System.Drawing.Point(234, 77);
            this.ButtonPlusMinus.Name = "ButtonPlusMinus";
            this.ButtonPlusMinus.Size = new System.Drawing.Size(68, 63);
            this.ButtonPlusMinus.TabIndex = 5;
            this.ButtonPlusMinus.Text = "±";
            this.ButtonPlusMinus.UseVisualStyleBackColor = false;
            this.ButtonPlusMinus.Click += new System.EventHandler(this.ButtonPlusMinus_Click);
            // 
            // ButtonLog
            // 
            this.ButtonLog.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonLog.Location = new System.Drawing.Point(337, 77);
            this.ButtonLog.Name = "ButtonLog";
            this.ButtonLog.Size = new System.Drawing.Size(68, 63);
            this.ButtonLog.TabIndex = 6;
            this.ButtonLog.Text = "Log";
            this.ButtonLog.UseVisualStyleBackColor = false;
            this.ButtonLog.Click += new System.EventHandler(this.ButtonLog_Click);
            // 
            // ButtonX2
            // 
            this.ButtonX2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonX2.Location = new System.Drawing.Point(411, 77);
            this.ButtonX2.Name = "ButtonX2";
            this.ButtonX2.Size = new System.Drawing.Size(68, 63);
            this.ButtonX2.TabIndex = 7;
            this.ButtonX2.Tag = "";
            this.ButtonX2.Text = "x^2";
            this.ButtonX2.UseVisualStyleBackColor = false;
            this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPlus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonPlus.Location = new System.Drawing.Point(233, 146);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(68, 63);
            this.ButtonPlus.TabIndex = 12;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = false;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Location = new System.Drawing.Point(159, 146);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 63);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.ButtonValue);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Location = new System.Drawing.Point(85, 146);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(68, 63);
            this.button10.TabIndex = 10;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.ButtonValue);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button11.Location = new System.Drawing.Point(11, 146);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(68, 63);
            this.button11.TabIndex = 9;
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.ButtonValue);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonMinus.Location = new System.Drawing.Point(233, 215);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(68, 63);
            this.ButtonMinus.TabIndex = 16;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = false;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button12.Location = new System.Drawing.Point(159, 215);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(68, 63);
            this.button12.TabIndex = 15;
            this.button12.Text = "6";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.ButtonValue);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button13.Location = new System.Drawing.Point(85, 215);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(68, 63);
            this.button13.TabIndex = 14;
            this.button13.Text = "5";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.ButtonValue);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button14.Location = new System.Drawing.Point(11, 215);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(68, 63);
            this.button14.TabIndex = 13;
            this.button14.Text = "4";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.ButtonValue);
            // 
            // ButtonNasobeni
            // 
            this.ButtonNasobeni.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonNasobeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonNasobeni.Location = new System.Drawing.Point(233, 284);
            this.ButtonNasobeni.Name = "ButtonNasobeni";
            this.ButtonNasobeni.Size = new System.Drawing.Size(68, 63);
            this.ButtonNasobeni.TabIndex = 20;
            this.ButtonNasobeni.Text = "*";
            this.ButtonNasobeni.UseVisualStyleBackColor = false;
            this.ButtonNasobeni.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button16.Location = new System.Drawing.Point(159, 284);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(68, 63);
            this.button16.TabIndex = 19;
            this.button16.Text = "3";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.ButtonValue);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button17.Location = new System.Drawing.Point(85, 284);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(68, 63);
            this.button17.TabIndex = 18;
            this.button17.Text = "2";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.ButtonValue);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button18.Location = new System.Drawing.Point(11, 284);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(68, 63);
            this.button18.TabIndex = 17;
            this.button18.Text = "1";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.ButtonValue);
            // 
            // ButtonDeleni
            // 
            this.ButtonDeleni.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonDeleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonDeleni.Location = new System.Drawing.Point(233, 353);
            this.ButtonDeleni.Name = "ButtonDeleni";
            this.ButtonDeleni.Size = new System.Drawing.Size(68, 63);
            this.ButtonDeleni.TabIndex = 24;
            this.ButtonDeleni.Text = "/";
            this.ButtonDeleni.UseVisualStyleBackColor = false;
            this.ButtonDeleni.Click += new System.EventHandler(this.ButtonClick);
            // 
            // ButtonRovnase
            // 
            this.ButtonRovnase.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonRovnase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonRovnase.Location = new System.Drawing.Point(159, 353);
            this.ButtonRovnase.Name = "ButtonRovnase";
            this.ButtonRovnase.Size = new System.Drawing.Size(68, 63);
            this.ButtonRovnase.TabIndex = 23;
            this.ButtonRovnase.Tag = "=";
            this.ButtonRovnase.Text = "=";
            this.ButtonRovnase.UseVisualStyleBackColor = false;
            this.ButtonRovnase.Click += new System.EventHandler(this.ButtonRovnase_Click);
            // 
            // ButtonTecka
            // 
            this.ButtonTecka.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonTecka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonTecka.Location = new System.Drawing.Point(85, 353);
            this.ButtonTecka.Name = "ButtonTecka";
            this.ButtonTecka.Size = new System.Drawing.Size(68, 63);
            this.ButtonTecka.TabIndex = 22;
            this.ButtonTecka.Text = ".";
            this.ButtonTecka.UseVisualStyleBackColor = false;
            this.ButtonTecka.Click += new System.EventHandler(this.ButtonValue);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button22.Location = new System.Drawing.Point(11, 353);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(68, 63);
            this.button22.TabIndex = 21;
            this.button22.Text = "0";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.ButtonValue);
            // 
            // ButtonX3
            // 
            this.ButtonX3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonX3.Location = new System.Drawing.Point(411, 146);
            this.ButtonX3.Name = "ButtonX3";
            this.ButtonX3.Size = new System.Drawing.Size(68, 63);
            this.ButtonX3.TabIndex = 26;
            this.ButtonX3.Text = "x^3";
            this.ButtonX3.UseVisualStyleBackColor = false;
            this.ButtonX3.Click += new System.EventHandler(this.ButtonX3_Click);
            // 
            // ButtonSin
            // 
            this.ButtonSin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonSin.Location = new System.Drawing.Point(337, 146);
            this.ButtonSin.Name = "ButtonSin";
            this.ButtonSin.Size = new System.Drawing.Size(68, 63);
            this.ButtonSin.TabIndex = 25;
            this.ButtonSin.Text = "Sin";
            this.ButtonSin.UseVisualStyleBackColor = false;
            this.ButtonSin.Click += new System.EventHandler(this.ButtonSin_Click);
            // 
            // Button1X
            // 
            this.Button1X.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Button1X.Location = new System.Drawing.Point(411, 215);
            this.Button1X.Name = "Button1X";
            this.Button1X.Size = new System.Drawing.Size(68, 63);
            this.Button1X.TabIndex = 28;
            this.Button1X.Text = "1/x";
            this.Button1X.UseVisualStyleBackColor = false;
            this.Button1X.Click += new System.EventHandler(this.Button1X_Click);
            // 
            // ButtonCos
            // 
            this.ButtonCos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonCos.Location = new System.Drawing.Point(337, 215);
            this.ButtonCos.Name = "ButtonCos";
            this.ButtonCos.Size = new System.Drawing.Size(68, 63);
            this.ButtonCos.TabIndex = 27;
            this.ButtonCos.Text = "Cos";
            this.ButtonCos.UseVisualStyleBackColor = false;
            this.ButtonCos.Click += new System.EventHandler(this.ButtonCos_Click);
            // 
            // ButtonLnx
            // 
            this.ButtonLnx.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonLnx.Location = new System.Drawing.Point(411, 284);
            this.ButtonLnx.Name = "ButtonLnx";
            this.ButtonLnx.Size = new System.Drawing.Size(68, 63);
            this.ButtonLnx.TabIndex = 30;
            this.ButtonLnx.Text = "ln x";
            this.ButtonLnx.UseVisualStyleBackColor = false;
            this.ButtonLnx.Click += new System.EventHandler(this.ButtonLnx_Click);
            // 
            // ButtonPercentage
            // 
            this.ButtonPercentage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonPercentage.Location = new System.Drawing.Point(411, 353);
            this.ButtonPercentage.Name = "ButtonPercentage";
            this.ButtonPercentage.Size = new System.Drawing.Size(68, 63);
            this.ButtonPercentage.TabIndex = 32;
            this.ButtonPercentage.Text = "%";
            this.ButtonPercentage.UseVisualStyleBackColor = false;
            this.ButtonPercentage.Click += new System.EventHandler(this.ButtonPercentage_Click);
            // 
            // ButtonPi
            // 
            this.ButtonPi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ButtonPi.Location = new System.Drawing.Point(337, 353);
            this.ButtonPi.Name = "ButtonPi";
            this.ButtonPi.Size = new System.Drawing.Size(68, 63);
            this.ButtonPi.TabIndex = 31;
            this.ButtonPi.Text = "π";
            this.ButtonPi.UseVisualStyleBackColor = false;
            this.ButtonPi.Click += new System.EventHandler(this.ButtonPi_Click);
            // 
            // ButtonCE
            // 
            this.ButtonCE.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonCE.Location = new System.Drawing.Point(85, 77);
            this.ButtonCE.Name = "ButtonCE";
            this.ButtonCE.Size = new System.Drawing.Size(68, 63);
            this.ButtonCE.TabIndex = 33;
            this.ButtonCE.Text = "CE";
            this.ButtonCE.UseVisualStyleBackColor = false;
            this.ButtonCE.Click += new System.EventHandler(this.ButtonCE_Click);
            // 
            // ButtonTan
            // 
            this.ButtonTan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonTan.Location = new System.Drawing.Point(337, 284);
            this.ButtonTan.Name = "ButtonTan";
            this.ButtonTan.Size = new System.Drawing.Size(68, 63);
            this.ButtonTan.TabIndex = 34;
            this.ButtonTan.Text = "Tan";
            this.ButtonTan.UseVisualStyleBackColor = false;
            this.ButtonTan.Click += new System.EventHandler(this.ButtonTan_Click);
            // 
            // lblShowOp
            // 
            this.lblShowOp.AutoSize = true;
            this.lblShowOp.Location = new System.Drawing.Point(21, 45);
            this.lblShowOp.Name = "lblShowOp";
            this.lblShowOp.Size = new System.Drawing.Size(0, 13);
            this.lblShowOp.TabIndex = 35;
            this.lblShowOp.Click += new System.EventHandler(this.ButtonValue);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.lblShowOp);
            this.Controls.Add(this.ButtonTan);
            this.Controls.Add(this.ButtonCE);
            this.Controls.Add(this.ButtonPercentage);
            this.Controls.Add(this.ButtonPi);
            this.Controls.Add(this.ButtonLnx);
            this.Controls.Add(this.Button1X);
            this.Controls.Add(this.ButtonCos);
            this.Controls.Add(this.ButtonX3);
            this.Controls.Add(this.ButtonSin);
            this.Controls.Add(this.ButtonDeleni);
            this.Controls.Add(this.ButtonRovnase);
            this.Controls.Add(this.ButtonTecka);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.ButtonNasobeni);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.ButtonX2);
            this.Controls.Add(this.ButtonLog);
            this.Controls.Add(this.ButtonPlusMinus);
            this.Controls.Add(this.ButtonC);
            this.Controls.Add(this.ButtonSpaceBack);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Aplikace Kalkulacka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakladniKalkulackaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vedeckaKalkulackaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ButtonSpaceBack;
        private System.Windows.Forms.Button ButtonC;
        private System.Windows.Forms.Button ButtonPlusMinus;
        private System.Windows.Forms.Button ButtonLog;
        private System.Windows.Forms.Button ButtonX2;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button ButtonNasobeni;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button ButtonDeleni;
        private System.Windows.Forms.Button ButtonRovnase;
        private System.Windows.Forms.Button ButtonTecka;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button ButtonX3;
        private System.Windows.Forms.Button ButtonSin;
        private System.Windows.Forms.Button Button1X;
        private System.Windows.Forms.Button ButtonCos;
        private System.Windows.Forms.Button ButtonLnx;
        private System.Windows.Forms.Button ButtonPercentage;
        private System.Windows.Forms.Button ButtonPi;
        private System.Windows.Forms.Button ButtonCE;
        private System.Windows.Forms.Button ButtonTan;
        private System.Windows.Forms.Label lblShowOp;
    }
}

