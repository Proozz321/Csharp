using Avalonia.Controls;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace OrderingSystemInterface;

public partial class MainWindow : Window
{
    private ObservableCollection<string> _itens = new();

    public MainWindow()
    {
        InitializeComponent();

        var lista = this.FindControl<ListBox>("Lista");
        var tabela = this.FindControl<DataGrid>("Tabela");
        var cob1 = this.FindControl<ComboBox>("Comb1");
        var cob2 = this.FindControl<ComboBox>("Comb2");
        var itens = new List<Dictionary<string, string>>();

        // Caminho do ficheiro — string precisa de aspas
        string caminho = "File/stock.txt";

        if(File.Exists(caminho))
        {

            string[] linha = File.ReadAllLines(caminho);

            for (int i = 0; i < linha.Length; i += 3)
            {
               itens.Add(new Dictionary<string, string>
                {
                    ["Nome"] = linha[i],
                    ["Preco"] = linha[i+1] + "€",
                    ["Quantidade"] = linha[i+2]
                });

                cob1.ItemsSource = new List<string> { linha[0],linha[3], linha[6]}; 
            }
        }
       tabela.ItemsSource = itens;

       
    }
}