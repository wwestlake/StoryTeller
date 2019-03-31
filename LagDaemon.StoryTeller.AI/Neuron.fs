namespace LagDaemon.StoryTeller.AI

module Neuron =
    let MODULE_NAME = "Neuron"

    type Neuron(weight: float) = 
        member this.Weight = weight 


        