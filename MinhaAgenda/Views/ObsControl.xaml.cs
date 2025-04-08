using System;
using Microsoft.Maui.Controls;

namespace MinhaAgenda.Views.Controls
{
    public partial class ObservacoesControl : ContentView
    {
        public event EventHandler? OnSave;

        public ObservacoesControl()
        {
            InitializeComponent();
        }

        public string? Observacao1 => txtObservacao1.Text;
        public string? Observacao2 => txtObservacao2.Text;

        private void OnSaveClicked(object sender, EventArgs e)
        {
            OnSave?.Invoke(this, EventArgs.Empty);
        }
    }
}
