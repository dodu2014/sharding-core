﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShardingCore.Core.EntityMetadatas;
using ShardingCore.Test5x.Domain.Entities;
using ShardingCore.VirtualRoutes.Weeks;

namespace ShardingCore.Test5x.Shardings
{
    public class LogWeekTimeLongVirtualTableRoute : AbstractSimpleShardingWeekKeyLongVirtualTableRoute<LogWeekTimeLong>
    {
        protected override bool EnableHintRoute => true;

        public override bool AutoCreateTableByTime()
        {
            return true;
        }

        public override DateTime GetBeginTime()
        {
            return new DateTime(2021, 1, 1);
        }

        public override void Configure(EntityMetadataTableBuilder<LogWeekTimeLong> builder)
        {
            builder.ShardingProperty(o => o.LogTime);
        }
    }
}
