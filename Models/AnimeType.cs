using System;
using System.Collections.Generic;

namespace LB4_AnimeTitlesApp.Models;

//класс модели соответствует модели в базе данных
//экземпляр класса - строка таблицы в базы данных  
public partial class AnimeType
{
    //св-во класса соответствует
    public short Id { get; set; }

    public string AnimeOfType { get; set; } = null!;

    //навигационное св-во
    //помогает свзяать таблицы в коде
    //одному типу аниме соответствует много тайтлов, т.е делается коллекция экземпляров
    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
