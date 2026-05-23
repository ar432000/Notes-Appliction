using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Application1.Models;

namespace Application1.ViewModels
{
    partial class NotesViewModel : INotifyPropertyChanged
    {
        private string? _noteTitle;

        private string? _noteDescription;

        private Note _selectedNote;

        public ObservableCollection<Note> Notes { get; set; }

        public string NoteTitle
        {
            get => _noteTitle;
            set
            {
                _noteTitle = value;
                OnPropertyChanged();
            }
        }

        public string NoteDescription
        {
            get => _noteDescription;
            set
            {
                _noteDescription = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddOrUpdateNoteCommand { get; }

        public ICommand DeleteNoteCommand { get; }

        public ICommand EditNoteCommand { get; }

        public NotesViewModel()
        {
            Notes = [];
            AddOrUpdateNoteCommand =
                new Command(AddOrUpdateNote);

            DeleteNoteCommand =
                new Command<Note>(DeleteNote);

            EditNoteCommand =
                new Command<Note>(EditNote);
        }

        private async void AddOrUpdateNote()
        {
            if (string.IsNullOrWhiteSpace(NoteTitle) ||
                string.IsNullOrWhiteSpace(NoteDescription))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Validation",
                    "Please enter title and description",
                    "OK");

                return;
            }

            // EDIT EXISTING NOTE
            if (_selectedNote != null)
            {
                _selectedNote.Title = NoteTitle;
                _selectedNote.Description = NoteDescription;

                // Refresh CollectionView
                var index = Notes.IndexOf(_selectedNote);

                Notes.RemoveAt(index);

                Notes.Insert(index, _selectedNote);

                _selectedNote = null;
            }
            else
            {
                // ADD NEW NOTE
                Notes.Add(new Note
                {
                    Title = NoteTitle,
                    Description = NoteDescription
                });
            }

            ClearFields();
        }

        private void EditNote(Note note)
        {
            if (note == null)
                return;

            _selectedNote = note;

            NoteTitle = note.Title;

            NoteDescription = note.Description;
        }

        private void DeleteNote(Note note)
        {
            if (note != null)
            {
                Notes.Remove(note);
            }
        }

        private void ClearFields()
        {
            NoteTitle = string.Empty;

            NoteDescription = string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}