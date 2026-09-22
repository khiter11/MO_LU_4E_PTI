using System.Collections.ObjectModel;

namespace NotatkiMobilne;

public partial class MainPage : ContentPage
{
    // Kolekcja powiadamiająca interfejs o zmianach
    public ObservableCollection<string> Notes { get; set; }

    public MainPage()
    {
        InitializeComponent();

        // Inicjalizacja z trzema początkowymi notatkami
        Notes = new ObservableCollection<string>
        {
            "Pierwsza ważna notatka",
            "Zakupy do domku",
            "Urodziny Ali"
        };

        // Powiązanie źródła danych z listą w XAML
        NotesListView.ItemsSource = Notes;
    }

    private void OnAddClicked(object sender, EventArgs e)
    {
        string newNote = NoteEntry.Text;

        // Sprawdzenie, czy pole nie jest puste lub białe
        if (!string.IsNullOrWhiteSpace(newNote))
        {
            // Dodanie elementu na koniec kolekcji (lista odświeży się automatycznie)
            Notes.Add(newNote);

            // Wyczyszczenie pola edycyjnego
            NoteEntry.Text = string.Empty;
        }
    }
}