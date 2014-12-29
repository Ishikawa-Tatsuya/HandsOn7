namespace FormsTarget
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("0_0_0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("0_0_1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("0_0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("0_1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("0", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Item0",
            "0_1",
            "0_2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Item1",
            "1_1",
            "1_2"}, -1);
            this._treeView = new System.Windows.Forms.TreeView();
            this._listView = new System.Windows.Forms.ListView();
            this.Col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._checkBox = new System.Windows.Forms.CheckBox();
            this._comboBox = new System.Windows.Forms.ComboBox();
            this._button = new System.Windows.Forms.Button();
            this.Col3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // _treeView
            // 
            this._treeView.LabelEdit = true;
            this._treeView.Location = new System.Drawing.Point(13, 193);
            this._treeView.Name = "_treeView";
            treeNode1.Name = "_node0_0_0";
            treeNode1.Text = "0_0_0";
            treeNode2.Name = "_node0_0_1";
            treeNode2.Text = "0_0_1";
            treeNode3.Name = "_node0_0";
            treeNode3.Text = "0_0";
            treeNode4.Name = "_node0_1";
            treeNode4.Text = "0_1";
            treeNode5.Name = "_node0";
            treeNode5.Text = "0";
            this._treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this._treeView.Size = new System.Drawing.Size(213, 97);
            this._treeView.TabIndex = 0;
            // 
            // _listView
            // 
            this._listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col1,
            this.Col2,
            this.Col3});
            this._listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this._listView.LabelEdit = true;
            this._listView.Location = new System.Drawing.Point(13, 90);
            this._listView.Name = "_listView";
            this._listView.Size = new System.Drawing.Size(213, 97);
            this._listView.TabIndex = 1;
            this._listView.UseCompatibleStateImageBehavior = false;
            this._listView.View = System.Windows.Forms.View.Details;
            // 
            // Col1
            // 
            this.Col1.Text = "Col1";
            // 
            // Col2
            // 
            this.Col2.Text = "Col2";
            // 
            // _checkBox
            // 
            this._checkBox.AutoSize = true;
            this._checkBox.Location = new System.Drawing.Point(13, 13);
            this._checkBox.Name = "_checkBox";
            this._checkBox.Size = new System.Drawing.Size(74, 16);
            this._checkBox.TabIndex = 2;
            this._checkBox.Text = "checkBox";
            this._checkBox.UseVisualStyleBackColor = true;
            // 
            // _comboBox
            // 
            this._comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this._comboBox.Location = new System.Drawing.Point(12, 35);
            this._comboBox.Name = "_comboBox";
            this._comboBox.Size = new System.Drawing.Size(140, 20);
            this._comboBox.TabIndex = 3;
            // 
            // _button
            // 
            this._button.Location = new System.Drawing.Point(13, 61);
            this._button.Name = "_button";
            this._button.Size = new System.Drawing.Size(75, 23);
            this._button.TabIndex = 4;
            this._button.UseVisualStyleBackColor = true;
            this._button.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Col3
            // 
            this.Col3.Text = "Col3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 301);
            this.Controls.Add(this._button);
            this.Controls.Add(this._comboBox);
            this.Controls.Add(this._checkBox);
            this.Controls.Add(this._listView);
            this.Controls.Add(this._treeView);
            this.Name = "MainForm";
            this.Text = "TargetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView _treeView;
        private System.Windows.Forms.ListView _listView;
        private System.Windows.Forms.CheckBox _checkBox;
        private System.Windows.Forms.ComboBox _comboBox;
        private System.Windows.Forms.ColumnHeader Col1;
        private System.Windows.Forms.ColumnHeader Col2;
        private System.Windows.Forms.Button _button;
        private System.Windows.Forms.ColumnHeader Col3;
    }
}

