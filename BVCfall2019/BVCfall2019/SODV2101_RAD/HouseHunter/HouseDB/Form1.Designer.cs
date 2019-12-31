namespace HouseDB
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
            this.houseHunterDBDataSet = new HouseDB.HouseHunterDBDataSet();
            this.tHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHouseTableAdapter = new HouseDB.HouseHunterDBDataSetTableAdapters.THouseTableAdapter();
            this.tableAdapterManager = new HouseDB.HouseHunterDBDataSetTableAdapters.TableAdapterManager();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.houseHunterDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // houseHunterDBDataSet
            // 
            this.houseHunterDBDataSet.DataSetName = "HouseHunterDBDataSet";
            this.houseHunterDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHouseBindingSource
            // 
            this.tHouseBindingSource.DataMember = "THouse";
            this.tHouseBindingSource.DataSource = this.houseHunterDBDataSet;
            // 
            // tHouseTableAdapter
            // 
            this.tHouseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.THouseTableAdapter = this.tHouseTableAdapter;
            this.tableAdapterManager.UpdateOrder = HouseDB.HouseHunterDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 26);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1316, 292);
            this.listBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Find All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.houseHunterDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHouseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HouseHunterDBDataSet houseHunterDBDataSet;
        private System.Windows.Forms.BindingSource tHouseBindingSource;
        private HouseHunterDBDataSetTableAdapters.THouseTableAdapter tHouseTableAdapter;
        private HouseHunterDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button1;
    }
}

