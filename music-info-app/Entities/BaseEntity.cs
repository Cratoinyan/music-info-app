using Swashbuckle.AspNetCore.Annotations;

namespace music_info_app.Entities
{
    public class BaseEntity
    {
        [SwaggerSchema(ReadOnly = true)]
        public int Id { get; set; }
    }
}
