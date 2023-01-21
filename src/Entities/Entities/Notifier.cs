using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entities;

public class Notifier
{
    public Notifier()
    {
        Notifiers = new List<Notifier>();
    }

    [NotMapped]
    public string PropertyName { get; set; }

    [NotMapped]
    public string Message { get; set; }

    [NotMapped]
    public List<Notifier> Notifiers { get; set; }

    public bool ValidatePropertyString(int value, string propertyName)
    {
        if (value < 1 || string.IsNullOrWhiteSpace(propertyName))
        {
            Notifiers.Add(new Notifier
            {
                Message = "Campo obrigatório",
                PropertyName = propertyName
            });

            return false;
        }

        return true;
    }
}