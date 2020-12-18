﻿namespace Destructurama.Attributed
{
    public class AttributedDestructuringPolicyOptions
    {
        /// <summary>
        /// By setting IgnoreNullProperties to true no need to set [NotLoggedIfDefault] for every logged property.
        /// Custom types implemenenting IEnumerable, will be destructed as StructureValue and affected by IgnoreNullProperties 
        /// only in case at least one property (or the type itself) has Destructurama attribute applied.
        /// </summary>
        public bool IgnoreNullProperties { get; set; }
    }
}
