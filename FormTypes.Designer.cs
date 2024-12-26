namespace LB4_AnimeTitlesApp
{
    partial class FormTypes
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonTypeUpdate = new Button();
            buttonTypeAdd = new Button();
            buttonTypeDelete = new Button();
            panelFill = new Panel();
            dataGridViewTypes = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonTypeAdd);
            flowLayoutPanel1.Controls.Add(buttonTypeUpdate);
            flowLayoutPanel1.Controls.Add(buttonTypeDelete);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1012, 100);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonTypeUpdate
            // 
            buttonTypeUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTypeUpdate.Location = new Point(186, 10);
            buttonTypeUpdate.Margin = new Padding(10);
            buttonTypeUpdate.Name = "buttonTypeUpdate";
            buttonTypeUpdate.Size = new Size(164, 45);
            buttonTypeUpdate.TabIndex = 1;
            buttonTypeUpdate.Text = "Редактировать";
            buttonTypeUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonTypeAdd
            // 
            buttonTypeAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTypeAdd.Location = new Point(10, 10);
            buttonTypeAdd.Margin = new Padding(10);
            buttonTypeAdd.Name = "buttonTypeAdd";
            buttonTypeAdd.Size = new Size(156, 45);
            buttonTypeAdd.TabIndex = 2;
            buttonTypeAdd.Text = "Добавить";
            buttonTypeAdd.UseVisualStyleBackColor = true;
            // 
            // buttonTypeDelete
            // 
            buttonTypeDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTypeDelete.Location = new Point(370, 10);
            buttonTypeDelete.Margin = new Padding(10);
            buttonTypeDelete.Name = "buttonTypeDelete";
            buttonTypeDelete.Size = new Size(164, 45);
            buttonTypeDelete.TabIndex = 3;
            buttonTypeDelete.Text = "Удалить";
            buttonTypeDelete.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewTypes);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 100);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(1012, 439);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.BackgroundColor = SystemColors.ControlLight;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.Location = new Point(10, 10);
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.Size = new Size(992, 419);
            dataGridViewTypes.TabIndex = 0;
            // 
            // FormTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 539);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanel1);
            Name = "FormTypes";
            Text = "Form1";
            Load += this.FormTypes_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonTypeUpdate;
        private Button buttonTypeAdd;
        private Button buttonTypeDelete;
        private Panel panelFill;
        private DataGridView dataGridViewTypes;
    }
}
