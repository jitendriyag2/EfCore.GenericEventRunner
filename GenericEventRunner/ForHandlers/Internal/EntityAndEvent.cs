﻿// Copyright (c) 2019 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using GenericEventRunner.ForEntities;

namespace GenericEventRunner.ForHandlers.Internal
{
    internal class EntityAndEvent
    {
        public EntityAndEvent(EntityEvents callingEntity, IDomainEvent domainEvent)
        {
            CallingEntity = callingEntity;
            DomainEvent = domainEvent;
        }

        public EntityEvents CallingEntity { get; }
        public IDomainEvent DomainEvent { get; }
    }
}