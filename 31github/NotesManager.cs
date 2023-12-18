using System;
using System.Collections.Generic;

public class NotesManager
{
    private List<Note> notes = new List<Note>();

    public void AddNote()
    {
        Console.WriteLine("Введите заголовок заметки:");
        string title = Console.ReadLine();

        Console.WriteLine("Введите содержание заметки:");
        string content = Console.ReadLine();

        Note newNote = new Note(title, content);
        notes.Add(newNote);
        Console.WriteLine("Заметка успешно добавлена.");
    }

    public void ViewNotes()
    {
        if (notes.Count == 0)
        {
            Console.WriteLine("У вас пока нет заметок.");
        }
        else
        {
            Console.WriteLine("Список заметок:");
            foreach (var note in notes)
            {
                Console.WriteLine($"Заголовок: {note.Title}");
                Console.WriteLine($"Содержание: {note.Content}\n");
            }
        }
    }

    public void DeleteNote()
    {
        if (notes.Count == 0)
        {
            Console.WriteLine("У вас нет заметок для удаления.");
            return;
        }

        Console.WriteLine("Введите заголовок заметки для удаления:");
        string titleToDelete = Console.ReadLine();

        Note noteToRemove = notes.Find(note => note.Title.Equals(titleToDelete, StringComparison.OrdinalIgnoreCase));

        if (noteToRemove != null)
        {
            notes.Remove(noteToRemove);
            Console.WriteLine("Заметка успешно удалена.");
        }
        else
        {
            Console.WriteLine("Заметка с таким заголовком не найдена.");
        }
    }
