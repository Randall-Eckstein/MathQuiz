namespace MathQuiz
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.timeLabel = new Label();
      this.label1 = new Label();
      this.plusLeftLabel = new Label();
      this.label2 = new Label();
      this.plusRightLabel = new Label();
      this.label4 = new Label();
      this.sum = new NumericUpDown();
      this.difference = new NumericUpDown();
      this.label3 = new Label();
      this.minusRightLabel = new Label();
      this.label6 = new Label();
      this.minusLeftLabel = new Label();
      this.product = new NumericUpDown();
      this.label8 = new Label();
      this.timesRightLabel = new Label();
      this.label10 = new Label();
      this.timesLeftLabel = new Label();
      this.quotient = new NumericUpDown();
      this.label12 = new Label();
      this.dividedRightLabel = new Label();
      this.label14 = new Label();
      this.dividedLeftLabel = new Label();
      this.startButton = new Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.label5 = new Label();
      this.dateLabel = new Label();
      ((System.ComponentModel.ISupportInitialize)this.sum).BeginInit();
      ((System.ComponentModel.ISupportInitialize)this.difference).BeginInit();
      ((System.ComponentModel.ISupportInitialize)this.product).BeginInit();
      ((System.ComponentModel.ISupportInitialize)this.quotient).BeginInit();
      this.SuspendLayout();
      // 
      // timeLabel
      // 
      this.timeLabel.BackColor = Color.Transparent;
      this.timeLabel.BorderStyle = BorderStyle.FixedSingle;
      this.timeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
      this.timeLabel.Location = new Point(192, 6);
      this.timeLabel.Name = "timeLabel";
      this.timeLabel.Size = new Size(200, 30);
      this.timeLabel.TabIndex = 0;
      this.timeLabel.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
      this.label1.Location = new Point(87, 6);
      this.label1.Name = "label1";
      this.label1.Size = new Size(99, 30);
      this.label1.TabIndex = 1;
      this.label1.Text = "Time Left";
      // 
      // plusLeftLabel
      // 
      this.plusLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.plusLeftLabel.Location = new Point(50, 39);
      this.plusLeftLabel.Name = "plusLeftLabel";
      this.plusLeftLabel.Size = new Size(60, 50);
      this.plusLeftLabel.TabIndex = 2;
      this.plusLeftLabel.Text = "?";
      this.plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // label2
      // 
      this.label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.label2.Location = new Point(116, 39);
      this.label2.Name = "label2";
      this.label2.Size = new Size(60, 50);
      this.label2.TabIndex = 3;
      this.label2.Text = "+";
      this.label2.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // plusRightLabel
      // 
      this.plusRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.plusRightLabel.Location = new Point(182, 39);
      this.plusRightLabel.Name = "plusRightLabel";
      this.plusRightLabel.Size = new Size(60, 50);
      this.plusRightLabel.TabIndex = 4;
      this.plusRightLabel.Text = "?";
      this.plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // label4
      // 
      this.label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.label4.Location = new Point(248, 39);
      this.label4.Name = "label4";
      this.label4.Size = new Size(60, 50);
      this.label4.TabIndex = 5;
      this.label4.Text = "=";
      this.label4.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // sum
      // 
      this.sum.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.sum.Location = new Point(314, 50);
      this.sum.Name = "sum";
      this.sum.Size = new Size(100, 39);
      this.sum.TabIndex = 1;
      this.sum.Enter += this.answer_Enter;
      // 
      // difference
      // 
      this.difference.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.difference.Location = new Point(314, 115);
      this.difference.Name = "difference";
      this.difference.Size = new Size(100, 39);
      this.difference.TabIndex = 2;
      this.difference.Enter += this.answer_Enter;
      // 
      // label3
      // 
      this.label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.label3.Location = new Point(248, 104);
      this.label3.Name = "label3";
      this.label3.Size = new Size(60, 50);
      this.label3.TabIndex = 10;
      this.label3.Text = "=";
      this.label3.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // minusRightLabel
      // 
      this.minusRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.minusRightLabel.Location = new Point(182, 104);
      this.minusRightLabel.Name = "minusRightLabel";
      this.minusRightLabel.Size = new Size(60, 50);
      this.minusRightLabel.TabIndex = 9;
      this.minusRightLabel.Text = "?";
      this.minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // label6
      // 
      this.label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.label6.Location = new Point(116, 104);
      this.label6.Name = "label6";
      this.label6.Size = new Size(60, 50);
      this.label6.TabIndex = 8;
      this.label6.Text = "-";
      this.label6.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // minusLeftLabel
      // 
      this.minusLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.minusLeftLabel.Location = new Point(50, 104);
      this.minusLeftLabel.Name = "minusLeftLabel";
      this.minusLeftLabel.Size = new Size(60, 50);
      this.minusLeftLabel.TabIndex = 7;
      this.minusLeftLabel.Text = "?";
      this.minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // product
      // 
      this.product.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.product.Location = new Point(314, 180);
      this.product.Name = "product";
      this.product.Size = new Size(100, 39);
      this.product.TabIndex = 3;
      this.product.Enter += this.answer_Enter;
      // 
      // label8
      // 
      this.label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.label8.Location = new Point(248, 169);
      this.label8.Name = "label8";
      this.label8.Size = new Size(60, 50);
      this.label8.TabIndex = 15;
      this.label8.Text = "=";
      this.label8.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // timesRightLabel
      // 
      this.timesRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.timesRightLabel.Location = new Point(182, 169);
      this.timesRightLabel.Name = "timesRightLabel";
      this.timesRightLabel.Size = new Size(60, 50);
      this.timesRightLabel.TabIndex = 14;
      this.timesRightLabel.Text = "?";
      this.timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // label10
      // 
      this.label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.label10.Location = new Point(116, 169);
      this.label10.Name = "label10";
      this.label10.Size = new Size(60, 50);
      this.label10.TabIndex = 13;
      this.label10.Text = "×";
      this.label10.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // timesLeftLabel
      // 
      this.timesLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.timesLeftLabel.Location = new Point(50, 169);
      this.timesLeftLabel.Name = "timesLeftLabel";
      this.timesLeftLabel.Size = new Size(60, 50);
      this.timesLeftLabel.TabIndex = 12;
      this.timesLeftLabel.Text = "?";
      this.timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // quotient
      // 
      this.quotient.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.quotient.Location = new Point(314, 245);
      this.quotient.Name = "quotient";
      this.quotient.Size = new Size(100, 39);
      this.quotient.TabIndex = 4;
      this.quotient.Enter += this.answer_Enter;
      // 
      // label12
      // 
      this.label12.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.label12.Location = new Point(248, 234);
      this.label12.Name = "label12";
      this.label12.Size = new Size(60, 50);
      this.label12.TabIndex = 20;
      this.label12.Text = "=";
      this.label12.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // dividedRightLabel
      // 
      this.dividedRightLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.dividedRightLabel.Location = new Point(182, 234);
      this.dividedRightLabel.Name = "dividedRightLabel";
      this.dividedRightLabel.Size = new Size(60, 50);
      this.dividedRightLabel.TabIndex = 19;
      this.dividedRightLabel.Text = "?";
      this.dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // label14
      // 
      this.label14.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.label14.Location = new Point(116, 234);
      this.label14.Name = "label14";
      this.label14.Size = new Size(60, 50);
      this.label14.TabIndex = 18;
      this.label14.Text = "÷";
      this.label14.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // dividedLeftLabel
      // 
      this.dividedLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
      this.dividedLeftLabel.Location = new Point(50, 234);
      this.dividedLeftLabel.Name = "dividedLeftLabel";
      this.dividedLeftLabel.Size = new Size(60, 50);
      this.dividedLeftLabel.TabIndex = 17;
      this.dividedLeftLabel.Text = "?";
      this.dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // startButton
      // 
      this.startButton.AutoSize = true;
      this.startButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
      this.startButton.Location = new Point(182, 299);
      this.startButton.Name = "startButton";
      this.startButton.Size = new Size(133, 35);
      this.startButton.TabIndex = 0;
      this.startButton.Text = "Start the quiz";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Click += this.startButton_Click;
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += this.timer1_Tick;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      this.label5.ForeColor = Color.FromArgb(0, 0, 192);
      this.label5.Location = new Point(10, 356);
      this.label5.Name = "label5";
      this.label5.Size = new Size(100, 21);
      this.label5.TabIndex = 21;
      this.label5.Text = "Today's Date:";
      // 
      // dateLabel
      // 
      this.dateLabel.AutoSize = true;
      this.dateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      this.dateLabel.ForeColor = Color.FromArgb(0, 0, 192);
      this.dateLabel.Location = new Point(116, 356);
      this.dateLabel.Name = "dateLabel";
      this.dateLabel.Size = new Size(85, 21);
      this.dateLabel.TabIndex = 22;
      this.dateLabel.Text = "4/27/2023";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new SizeF(7F, 15F);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(484, 386);
      this.Controls.Add(this.dateLabel);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.startButton);
      this.Controls.Add(this.quotient);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.dividedRightLabel);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.dividedLeftLabel);
      this.Controls.Add(this.product);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.timesRightLabel);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.timesLeftLabel);
      this.Controls.Add(this.difference);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.minusRightLabel);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.minusLeftLabel);
      this.Controls.Add(this.sum);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.plusRightLabel);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.plusLeftLabel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.timeLabel);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Randall Eckstein - Math Quiz";
      ((System.ComponentModel.ISupportInitialize)this.sum).EndInit();
      ((System.ComponentModel.ISupportInitialize)this.difference).EndInit();
      ((System.ComponentModel.ISupportInitialize)this.product).EndInit();
      ((System.ComponentModel.ISupportInitialize)this.quotient).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private Label timeLabel;
    private Label label1;
    private Label plusLeftLabel;
    private Label label2;
    private Label plusRightLabel;
    private Label label4;
    private NumericUpDown sum;
    private NumericUpDown difference;
    private Label label3;
    private Label minusRightLabel;
    private Label label6;
    private Label minusLeftLabel;
    private NumericUpDown product;
    private Label label8;
    private Label timesRightLabel;
    private Label label10;
    private Label timesLeftLabel;
    private NumericUpDown quotient;
    private Label label12;
    private Label dividedRightLabel;
    private Label label14;
    private Label dividedLeftLabel;
    private Button startButton;
    private System.Windows.Forms.Timer timer1;
    private Label label5;
    private Label dateLabel;
  }
}