using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace CadastroDeAcordos.Classes
{
    class GeraRelatorio
    {

        public void ExportarDadosParaExcel(DataTable tabela, string titulo)
        {
            try
            {
                var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("Planilha 1");
                var alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                //título do relatório
                ws.Cell("B2").Value = titulo;
                var range = ws.Range($"A1:{tabela.Columns.Count}");
                range.Merge().Style.Font.SetBold().Font.FontSize = 20;

                //Cabeçalhos do relatório
                for (int i = 0; i < tabela.Columns.Count; i++)
                {
                    ws.Cell($"{alfabeto[i]}2").Value = tabela.Columns[i].ColumnName;
                }

                // Corpo do relatório
                var linha = 3;

                for (int i = linha; i < tabela.Rows.Count; i++)
                {
                    for (int j = 0; j < tabela.Columns.Count; j++)
                    {
                        ws.Cell($"{alfabeto[j]}{i}").Value = tabela;
                    }

                    

                    ws.Cell("B" + linha.ToString()).Value = "B" + i.ToString();
                    ws.Cell("C" + linha.ToString()).Value = "C" + i.ToString();
                    ws.Cell("D" + linha.ToString()).Value = "D" + i.ToString();
                    ws.Cell("E" + linha.ToString()).Value = "E" + i.ToString();
                    ws.Cell("F" + linha.ToString()).Value = "F" + i.ToString();
                    ws.Cell("G" + linha.ToString()).Value = "G" + i.ToString();
                    ws.Cell("H" + linha.ToString()).Value = "H" + i.ToString();
                    ws.Cell("I" + linha.ToString()).Value = string.Format("{0:F2}", i * linha);
                    linha++;
                }

                // ajusta a numeração da linha
                linha--;

                // cria a formatação do tipo "money" para o subtotal
                ws.Range("I4:I" + linha.ToString()).Style.NumberFormat.Format = "R$ #,#.##00";

                // cria uma tabela para ativar os Filtros
                range = ws.Range("B3:I" + linha.ToString());
                range.CreateTable();

                // ajusta o tamanho da coluna de acordo com o seu conteúdo
                ws.Columns("2-9").AdjustToContents();

                // salvar o arquivo em disco
                wb.SaveAs(@"C:\Users\Andreson\Downloads\teste.xlsx");

                //MessageBox.Show("Feito!");
            }
            catch (Exception)
            {
                
            }
        }
    }
}
