using Elements.Core;
using FrooxEngine;
using ProtoFlux.Core;
using ProtoFlux.Runtimes.Execution;
using System;
using FrooxEngine.ProtoFlux;

namespace ProtoFlux.Runtimes.Execution.Nodes.Obsidian.Math.Physics
{
    [NodeCategory("Obsidian/Math/Physics")]
    public class KineticFrictionNode : ValueFunctionNode<FrooxEngineContext, float3>
    {
        public ValueInput<float3> NormalForce;
        public ValueInput<float> KineticFrictionCoefficient;

        protected override float3 Compute(FrooxEngineContext context)
        {
            float3 normal = NormalForce.Evaluate(context);
            float coefficient = KineticFrictionCoefficient.Evaluate(context);

            // Kinetic friction formula: f_kinetic = mu_kinetic * N
            float3 kineticFrictionalForce = coefficient * normal;
            return kineticFrictionalForce;
        }
    }
}
