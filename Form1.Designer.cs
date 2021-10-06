namespace FreezingCounter
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
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelStartStop = new System.Windows.Forms.Label();
            this.labelFreezingDuration = new System.Windows.Forms.Label();
            this.labelTotalFreezing = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMeasureDuration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(28, 9);
            this.labelInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(23, 18);
            this.labelInstructions.TabIndex = 0;
            this.labelInstructions.Text = "---";
            // 
            // labelStartStop
            // 
            this.labelStartStop.AutoSize = true;
            this.labelStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartStop.Location = new System.Drawing.Point(63, 127);
            this.labelStartStop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartStop.Name = "labelStartStop";
            this.labelStartStop.Size = new System.Drawing.Size(31, 24);
            this.labelStartStop.TabIndex = 2;
            this.labelStartStop.Text = "---";
            // 
            // labelFreezingDuration
            // 
            this.labelFreezingDuration.AutoSize = true;
            this.labelFreezingDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFreezingDuration.Location = new System.Drawing.Point(200, 168);
            this.labelFreezingDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFreezingDuration.Name = "labelFreezingDuration";
            this.labelFreezingDuration.Size = new System.Drawing.Size(31, 24);
            this.labelFreezingDuration.TabIndex = 3;
            this.labelFreezingDuration.Text = "---";
            this.labelFreezingDuration.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTotalFreezing
            // 
            this.labelTotalFreezing.AutoSize = true;
            this.labelTotalFreezing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFreezing.Location = new System.Drawing.Point(200, 252);
            this.labelTotalFreezing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalFreezing.Name = "labelTotalFreezing";
            this.labelTotalFreezing.Size = new System.Drawing.Size(31, 24);
            this.labelTotalFreezing.TabIndex = 4;
            this.labelTotalFreezing.Text = "---";
            this.labelTotalFreezing.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Freeze (sec):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Freezing (%):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total time (sec):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMeasureDuration
            // 
            this.labelMeasureDuration.AutoSize = true;
            this.labelMeasureDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeasureDuration.Location = new System.Drawing.Point(200, 210);
            this.labelMeasureDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMeasureDuration.Name = "labelMeasureDuration";
            this.labelMeasureDuration.Size = new System.Drawing.Size(31, 24);
            this.labelMeasureDuration.TabIndex = 8;
            this.labelMeasureDuration.Text = "---";
            this.labelMeasureDuration.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMeasureDuration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTotalFreezing);
            this.Controls.Add(this.labelFreezingDuration);
            this.Controls.Add(this.labelStartStop);
            this.Controls.Add(this.labelInstructions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Freezing Counter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label labelStartStop;
        private System.Windows.Forms.Label labelFreezingDuration;
        private System.Windows.Forms.Label labelTotalFreezing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMeasureDuration;
    }
}

