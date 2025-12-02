namespace Presentacion
{
    partial class frmResumen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chGraficoHLA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chProduccionPorRaza = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chGraficoHLA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chProduccionPorRaza)).BeginInit();
            this.SuspendLayout();
            // 
            // chGraficoHLA
            // 
            this.chGraficoHLA.BackColor = System.Drawing.Color.Beige;
            this.chGraficoHLA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.chGraficoHLA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chGraficoHLA.Legends.Add(legend1);
            this.chGraficoHLA.Location = new System.Drawing.Point(242, 341);
            this.chGraficoHLA.Name = "chGraficoHLA";
            this.chGraficoHLA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 5;
            this.chGraficoHLA.Series.Add(series1);
            this.chGraficoHLA.Size = new System.Drawing.Size(583, 217);
            this.chGraficoHLA.TabIndex = 0;
            this.chGraficoHLA.Text = "nrtnrtntrntr";
            // 
            // chProduccionPorRaza
            // 
            this.chProduccionPorRaza.BackColor = System.Drawing.Color.Beige;
            this.chProduccionPorRaza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea2.Name = "ChartArea1";
            this.chProduccionPorRaza.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chProduccionPorRaza.Legends.Add(legend2);
            this.chProduccionPorRaza.Location = new System.Drawing.Point(36, 54);
            this.chProduccionPorRaza.Name = "chProduccionPorRaza";
            this.chProduccionPorRaza.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series2.YValuesPerPoint = 5;
            this.chProduccionPorRaza.Series.Add(series2);
            this.chProduccionPorRaza.Size = new System.Drawing.Size(925, 254);
            this.chProduccionPorRaza.TabIndex = 1;
            this.chProduccionPorRaza.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "                                        \r\n                   \r\n         ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(824, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "                                        \r\n                   \r\n         ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produccion de Leche por Raza de Animales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(403, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad General de Hectareas, Lotes de Animales y Animales";
            // 
            // frmResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chProduccionPorRaza);
            this.Controls.Add(this.chGraficoHLA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResumen";
            this.Text = "frmResumen";
            ((System.ComponentModel.ISupportInitialize)(this.chGraficoHLA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chProduccionPorRaza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chGraficoHLA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chProduccionPorRaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}