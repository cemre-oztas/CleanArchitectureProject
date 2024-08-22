namespace CleanArchitecture.Domain.Common;

public class Entity
{
    public Guid Id { get; set; } = Guid.NewGuid();      // Id alanı için otomatik olarak yeni bir GUID oluşturması için
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;  //Nesne oluşturulurken tarih otomatik olarak ayarlanması için
    virtual public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;  //Güncellenme tarihi otomatik olarak ayarlanması için
}
