namespace Semantica.TestTools.Core;

public abstract class ModuleTestBase<TModule>
    where TModule : class
{
    /// <summary>
    /// System under test. Has to be assigned during construction or initialization of the test class.
    /// </summary>
    protected TModule Sut = null!;

    /// <summary>
    /// Performs the Act part of the generic test. Call from <see cref="Register_Verify_DoesNotThrow"/>.
    /// </summary>
    protected abstract void Act(bool findOtherModulesInSameAssembly = true);

    /// <summary>
    /// Performs the Assert parts of the generic test. Call from <see cref="Register_Verify_DoesNotThrow"/>.
    /// </summary>
    protected abstract void Assert();

    /// <summary>
    /// Initializes the test. Call before <see cref="ModuleTestBase{TModule}.Act"/>;
    /// </summary>
    protected abstract void Initialize();

    /// <summary>
    /// Registers a generic mock to represent a dependency that is always implemented in an upstream module.
    /// </summary>
    /// <remarks>
    /// Use in the override of the <see cref="RegisterInvertedDependencies"/> method.
    /// </remarks>
    /// <typeparam name="TDependency">Type to register a generic mock for.</typeparam>
    protected abstract void RegisterAsMock<TDependency>()
        where TDependency : class;

    /// <summary>
    /// Override this method to registers all dependencies that are always implemented in a module that is upstream from the
    /// context of this module. Note that any implementations registered here always have to be registered, otherwise the
    /// runtime (verification) will fail. The registrations added here effectively create unavoidable "blind spots" for the
    /// unit test verification.  
    /// </summary>
    protected virtual void RegisterInvertedDependencies()
    {
    }

    /// <summary>
    /// Test method to be called by the unittesting framework.
    /// </summary>
    /// <remarks>
    /// Should call <see cref="ModuleTestBase{TModule}.Act"/> and <see cref="ModuleTestBase{TModule}.Assert"/> for the test to
    /// work.
    /// </remarks>
    public abstract void Register_Verify_DoesNotThrow();
}
