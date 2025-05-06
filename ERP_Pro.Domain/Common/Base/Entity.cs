using System;

namespace ERP_Pro.Domain.Common.Base
{
    /// <summary>
    /// الفئة الأساسية لجميع الكيانات في النظام
    /// </summary>
    public abstract class Entity : IEquatable<Entity>
    {
        /// <summary>
        /// المعرف الفريد للكيان
        /// </summary>
        public Guid Id { get; protected set; }

        protected Entity() { }

        public override bool Equals(object obj)
        {
            return obj is Entity entity && Equals(entity);
        }

        public bool Equals(Entity other)
        {
            if (other is null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (GetType() != other.GetType())
                return false;

            if (Id == Guid.Empty || other.Id == Guid.Empty)
                return false;

            return Id == other.Id;
        }

        public static bool operator ==(Entity left, Entity right)
        {
            if (left is null && right is null)
                return true;

            if (left is null || right is null)
                return false;

            return left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return (GetType().ToString() + Id).GetHashCode();
        }
    }
} 