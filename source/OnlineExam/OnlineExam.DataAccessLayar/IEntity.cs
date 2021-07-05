namespace OnlineExam.DataAccessLayar
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
