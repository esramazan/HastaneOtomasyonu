namespace Hastahane
{
    partial class BölTab
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
            this.bolumDataGridView = new System.Windows.Forms.DataGridView();
            this.hastahaneDataSet9 = new Hastahane.HastahaneDataSet9();
            this.bolumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolumTableAdapter = new Hastahane.HastahaneDataSet9TableAdapters.BolumTableAdapter();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bolumDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastahaneDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bolumDataGridView
            // 
            this.bolumDataGridView.AutoGenerateColumns = false;
            this.bolumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bolumDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumadiDataGridViewTextBoxColumn});
            this.bolumDataGridView.DataSource = this.bolumBindingSource;
            this.bolumDataGridView.Location = new System.Drawing.Point(12, 68);
            this.bolumDataGridView.Name = "bolumDataGridView";
            this.bolumDataGridView.Size = new System.Drawing.Size(305, 221);
            this.bolumDataGridView.TabIndex = 1;
            // 
            // hastahaneDataSet9
            // 
            this.hastahaneDataSet9.DataSetName = "HastahaneDataSet9";
            this.hastahaneDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumBindingSource
            // 
            this.bolumBindingSource.DataMember = "Bolum";
            this.bolumBindingSource.DataSource = this.hastahaneDataSet9;
            // 
            // bolumTableAdapter
            // 
            this.bolumTableAdapter.ClearBeforeFill = true;
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolum_id";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolum_id";
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            // 
            // bolumadiDataGridViewTextBoxColumn
            // 
            this.bolumadiDataGridViewTextBoxColumn.DataPropertyName = "Bolum_adi";
            this.bolumadiDataGridViewTextBoxColumn.HeaderText = "Bolum_adi";
            this.bolumadiDataGridViewTextBoxColumn.Name = "bolumadiDataGridViewTextBoxColumn";
            // 
            // BölTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 391);
            this.Controls.Add(this.bolumDataGridView);
            this.Name = "BölTab";
            this.Text = "Bölüm Tablosu";
            this.Load += new System.EventHandler(this.BölTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bolumDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastahaneDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bolumDataGridView;
        private HastahaneDataSet9 hastahaneDataSet9;
        private System.Windows.Forms.BindingSource bolumBindingSource;
        private HastahaneDataSet9TableAdapters.BolumTableAdapter bolumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumadiDataGridViewTextBoxColumn;
    }
}