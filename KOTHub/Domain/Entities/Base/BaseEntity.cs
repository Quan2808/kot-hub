// namespace Domain.Entities.Base;
//
// using System;
// using System.ComponentModel.DataAnnotations;
// using System.ComponentModel.DataAnnotations.Schema;
//
// /// <summary>
// /// Represents a base entity with common properties for all domain entities.
// /// <typeparam name="TKey">The type of the primary key (e.g., Guid, int, long).</typeparam>
// /// </summary>
// /// public class Product : BaseEntity<Guid>
// // {
// // public string Name { get; set; }
// // public decimal Price { get; set; }
// // public string Description { get; set; }
// // }
// public abstract class BaseEntity<TKey> where TKey : IEquatable<TKey>
// {
//     /// <summary>
//     /// Gets or sets the unique identifier for the entity.
//     /// </summary>
//     [Key]
//     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//     public TKey Id { get; set; }
//
//     /// <summary>
//     /// Gets or sets the date and time when the entity was created.
//     /// </summary>
//     [Required]
//     public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
//
//     /// <summary>
//     /// Gets or sets the date and time when the entity was last updated.
//     /// </summary>
//     public DateTime? UpdatedAt { get; set; }
//
//     /// <summary>
//     /// Gets or sets the user who created the entity.
//     /// </summary>
//     [MaxLength(100)]
//     public string CreatedBy { get; set; }
//
//     /// <summary>
//     /// Gets or sets the user who last updated the entity.
//     /// </summary>
//     [MaxLength(100)]
//     public string UpdatedBy { get; set; }
//
//     /// <summary>
//     /// Gets or sets a value indicating whether the entity is marked as deleted.
//     /// </summary>
//     public bool IsDeleted { get; set; } = false;
//
//     /// <summary>
//     /// Initializes a new instance of the <see cref="BaseEntity{TKey}"/> class.
//     /// </summary>
//     protected BaseEntity()
//     {
//         // Ensure CreatedAt is set to UTC time by default
//         CreatedAt = DateTime.UtcNow;
//     }
//
//     /// <summary>
//     /// Marks the entity as deleted (soft delete).
//     /// </summary>
//     /// <param name="deletedBy">The user who marked the entity as deleted.</param>
//     public virtual void MarkAsDeleted(string deletedBy = null)
//     {
//         IsDeleted = true;
//         UpdatedAt = DateTime.UtcNow;
//         UpdatedBy = deletedBy;
//     }
//
//     /// <summary>
//     /// Updates the entity's last modified timestamp and user.
//     /// </summary>
//     /// <param name="updatedBy">The user who updated the entity.</param>
//     public virtual void Update(string updatedBy = null)
//     {
//         UpdatedAt = DateTime.UtcNow;
//         UpdatedBy = updatedBy;
//     }
//
//     /// <summary>
//     /// Determines whether the specified object is equal to the current entity.
//     /// </summary>
//     /// <param name="obj">The object to compare with the current entity.</param>
//     /// <returns>True if the objects are considered equal; otherwise, false.</returns>
//     public override bool Equals(object obj)
//     {
//         if (obj == null || GetType() != obj.GetType())
//             return false;
//
//         var other = (BaseEntity<TKey>)obj;
//         return Id.Equals(other.Id);
//     }
//
//     /// <summary>
//     /// Serves as the default hash function.
//     /// </summary>
//     /// <returns>A hash code for the current entity.</returns>
//     public override int GetHashCode()
//     {
//         return Id.GetHashCode();
//     }
// }