namespace Semantica.Domain.DesignAttributes;

/// <summary>
/// Describes the purpose of a model in the solution, be describing what it represents (entity, value object, view), where it's
/// used (domain layer, storage(/persistence) layer, application layer), what kind of model it is (isolation or aggregation),
/// and what it's usage is (reading/adding/replacing)
/// </summary>
[Flags]
public enum ModelPurpose
{
    // what:
    /// <summary>
    /// Model represents an entity in your domain. If this flag is not set, and neither is <see cref="View"/>, the model
    /// represents a value object. 
    /// </summary>
    Entity = 1 << 0,
    /// <summary>
    /// Model is a subset of the properties of an entity (if <see cref="Entity"/> flag is set), or of/derived drom multiple
    /// entities or aggregation of entities. 
    /// </summary>
    View = 1 << 1,
    
    // where:
    /// <summary>
    /// Model is made for use in the Domain layer.
    /// </summary>
    Domain = 1 << 4,
    /// <summary>
    /// Model is made for use in the Storage layer.
    /// </summary>
    Storage = 1 << 5,
    /// <summary>
    /// Model is made for use in the Application layer (what would generally be called a ViewModel in the MVC/MVVM patterns).
    /// </summary>
    Application = 1 << 6,
    
    // kind:
    /// <summary>
    /// Model is meant for use in repositories. i.e. (generally) does not have properties referencing other entity models
    /// (outside of sub entities), such relations are represented by a foreign key property instead. If this flag is omitted,
    /// the model is considered an aggregation model.  
    /// </summary>
    Isolation = 1 << 8,
    
    // usage:
    /// <summary>
    /// Model is used for getting (reading) elements/data from the repository or inventory.
    /// </summary>
    Get = 1 << 12,
    /// <summary>
    /// Model is used for adding new elements to the repository. In principal, these models should always be
    /// <see cref="Isolation"/> models.
    /// </summary>
    Add = 1 << 13,
    /// <summary>
    /// Model is used for replacing existing elements in the repository. In principal, these models should always be
    /// <see cref="Isolation"/> models.
    /// </summary>
    Replace = 1 << 14,
    
    // combined:
    /// <summary>
    /// Combined flag: Model is used in the repository for read, add and replace methods. 
    /// </summary>
    Repository = Isolation | Add | Replace
}
