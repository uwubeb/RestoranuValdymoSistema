namespace RestoranuValdymoSistema.Data.Contracts.Note;

public class NoteContract
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public string Text { get; set; }
}