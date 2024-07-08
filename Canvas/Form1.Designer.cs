namespace DrawingApp
{
    partial class DrawingForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // DrawingForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "DrawingForm";
            this.Text = "Drawing App";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawingForm_MouseUp);

            this.ResumeLayout(false);
        }
    }
}
