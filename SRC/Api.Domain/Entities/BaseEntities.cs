
using System;
using System.ComponentModel.DataAnnotations;
namespace Api.Domain.Entities
{

    public abstract class BaseEntities
    {
        [Key]
        public Guid Id { get; set; }

        private DateTime _createAt;
        public DateTime createAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get; set; }


    }
}