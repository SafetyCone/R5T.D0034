using System;

using R5T.Lombardy;using R5T.T0064;


namespace R5T.D0034.Default
{[ServiceImplementationMarker]
    public class VisualStudioProjectFileProjectReferencePathProvider : IVisualStudioProjectFileProjectReferencePathProvider,IServiceImplementation
    {
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public VisualStudioProjectFileProjectReferencePathProvider(
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string GetProjectReferenceFilePath(string projectFilePath, string projectReferenceFileRelativePath)
        {
            // The key is that we have to combine the project file directory path with the project reference file relative path.
            var projectFileDirectoryPath = this.StringlyTypedPathOperator.GetDirectoryPathForFilePath(projectFilePath);

            var projectReferenceFilePath = this.StringlyTypedPathOperator.Combine(projectFileDirectoryPath, projectReferenceFileRelativePath);
            return projectReferenceFilePath;
        }
    }
}
