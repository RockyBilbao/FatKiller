using System;
using System.Xml.Serialization;

namespace FatKiller.Data.Model.ModelsBase
{
    [Serializable]
    public class EntityBase
    {
        public EntityBase()
        {
            CreateDate = DateTime.Now;
        }

        [XmlIgnore]
        public Guid? CreateUserId { get; set; }

        [XmlIgnore]
        public DateTime? CreateDate { get; set; }

        [XmlIgnore]
        public Guid? ModifyUserId { get; set; }

        [XmlIgnore]
        public DateTime? ModifyDate { get; set; }

    }
}
