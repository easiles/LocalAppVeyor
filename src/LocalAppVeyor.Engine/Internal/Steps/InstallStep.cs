﻿using LocalAppVeyor.Engine.Configuration;

namespace LocalAppVeyor.Engine.Internal.Steps
{
    internal class InstallStep : ScriptBlockExecuterStep
    {
        public InstallStep(ScriptBlock scriptBlock) : base(scriptBlock)
        {
        }
    }
}