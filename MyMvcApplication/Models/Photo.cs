using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Photo
{
    public virtual int PicID { get; set; }
    public virtual int CharacterID { get; set; }
    public virtual string Title { get; set; }
    public virtual DateTime Time { get; set; }
    public virtual string Character { get; set; }


}