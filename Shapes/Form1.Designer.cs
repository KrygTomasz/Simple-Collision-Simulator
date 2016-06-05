namespace Shapes
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelRectangleAreaCalculated = new System.Windows.Forms.Label();
            this.labelSquareAreaCalculated = new System.Windows.Forms.Label();
            this.labelCircleAreaCalculated = new System.Windows.Forms.Label();
            this.labelRectangleArea = new System.Windows.Forms.Label();
            this.labelSquareArea = new System.Windows.Forms.Label();
            this.labelCircleArea = new System.Windows.Forms.Label();
            this.buttonArea = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.timerMoving = new System.Windows.Forms.Timer(this.components);
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonClear);
            this.splitContainer1.Panel1.Controls.Add(this.labelRectangleAreaCalculated);
            this.splitContainer1.Panel1.Controls.Add(this.labelSquareAreaCalculated);
            this.splitContainer1.Panel1.Controls.Add(this.labelCircleAreaCalculated);
            this.splitContainer1.Panel1.Controls.Add(this.labelRectangleArea);
            this.splitContainer1.Panel1.Controls.Add(this.labelSquareArea);
            this.splitContainer1.Panel1.Controls.Add(this.labelCircleArea);
            this.splitContainer1.Panel1.Controls.Add(this.buttonArea);
            this.splitContainer1.Panel1.Controls.Add(this.buttonGenerate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(771, 518);
            this.splitContainer1.SplitterDistance = 88;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelRectangleAreaCalculated
            // 
            this.labelRectangleAreaCalculated.AutoSize = true;
            this.labelRectangleAreaCalculated.Location = new System.Drawing.Point(308, 47);
            this.labelRectangleAreaCalculated.Name = "labelRectangleAreaCalculated";
            this.labelRectangleAreaCalculated.Size = new System.Drawing.Size(0, 13);
            this.labelRectangleAreaCalculated.TabIndex = 7;
            // 
            // labelSquareAreaCalculated
            // 
            this.labelSquareAreaCalculated.AutoSize = true;
            this.labelSquareAreaCalculated.Location = new System.Drawing.Point(308, 30);
            this.labelSquareAreaCalculated.Name = "labelSquareAreaCalculated";
            this.labelSquareAreaCalculated.Size = new System.Drawing.Size(0, 13);
            this.labelSquareAreaCalculated.TabIndex = 6;
            // 
            // labelCircleAreaCalculated
            // 
            this.labelCircleAreaCalculated.AutoSize = true;
            this.labelCircleAreaCalculated.Location = new System.Drawing.Point(308, 13);
            this.labelCircleAreaCalculated.Name = "labelCircleAreaCalculated";
            this.labelCircleAreaCalculated.Size = new System.Drawing.Size(0, 13);
            this.labelCircleAreaCalculated.TabIndex = 5;
            // 
            // labelRectangleArea
            // 
            this.labelRectangleArea.AutoSize = true;
            this.labelRectangleArea.Location = new System.Drawing.Point(206, 47);
            this.labelRectangleArea.Name = "labelRectangleArea";
            this.labelRectangleArea.Size = new System.Drawing.Size(84, 13);
            this.labelRectangleArea.TabIndex = 4;
            this.labelRectangleArea.Text = "Rectangle Area:";
            // 
            // labelSquareArea
            // 
            this.labelSquareArea.AutoSize = true;
            this.labelSquareArea.Location = new System.Drawing.Point(206, 30);
            this.labelSquareArea.Name = "labelSquareArea";
            this.labelSquareArea.Size = new System.Drawing.Size(69, 13);
            this.labelSquareArea.TabIndex = 3;
            this.labelSquareArea.Text = "Square Area:";
            // 
            // labelCircleArea
            // 
            this.labelCircleArea.AutoSize = true;
            this.labelCircleArea.Location = new System.Drawing.Point(206, 13);
            this.labelCircleArea.Name = "labelCircleArea";
            this.labelCircleArea.Size = new System.Drawing.Size(61, 13);
            this.labelCircleArea.TabIndex = 2;
            this.labelCircleArea.Text = "Circle Area:";
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(95, 13);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(75, 23);
            this.buttonArea.TabIndex = 1;
            this.buttonArea.Text = "Area";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(13, 13);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // timerMoving
            // 
            this.timerMoving.Interval = 40;
            this.timerMoving.Tick += new System.EventHandler(this.timerMoving_Tick);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(13, 47);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 518);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Timer timerMoving;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.Label labelRectangleArea;
        private System.Windows.Forms.Label labelSquareArea;
        private System.Windows.Forms.Label labelCircleArea;
        private System.Windows.Forms.Label labelRectangleAreaCalculated;
        private System.Windows.Forms.Label labelSquareAreaCalculated;
        private System.Windows.Forms.Label labelCircleAreaCalculated;
        private System.Windows.Forms.Button buttonClear;

    }
}

