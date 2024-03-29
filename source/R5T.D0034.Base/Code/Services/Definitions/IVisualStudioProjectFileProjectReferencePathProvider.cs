﻿using System;

using R5T.T0064;


namespace R5T.D0034
{
    /// <summary>
    /// Takes care of the tricky situation where appending a dependency project file relative path to the project file path results in a nonsense path.
    /// Basically, the project reference relative file paths are relative to the project file *directory*, not the project file itself.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IVisualStudioProjectFileProjectReferencePathProvider : IServiceDefinition
    {
        string GetProjectReferenceFilePath(string projectFilePath, string projectReferenceFileRelativePath);
    }
}
