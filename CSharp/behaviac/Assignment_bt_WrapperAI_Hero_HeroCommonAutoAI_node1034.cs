﻿namespace behaviac
{
    using System;

    internal class Assignment_bt_WrapperAI_Hero_HeroCommonAutoAI_node1034 : Assignment
    {
        protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
        {
            EBTStatus status = EBTStatus.BT_SUCCESS;
            int num = 0xe1;
            pAgent.SetVariable<int>("p_idleMod", num, 0x8bd66236);
            return status;
        }
    }
}

