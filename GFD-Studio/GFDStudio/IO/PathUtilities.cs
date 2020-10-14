﻿using System;
using System.IO;

namespace GFDStudio.IO
{
    public static class PathUtilities
    {
        public static bool MatchesAnyExtension( string filename, params string[] extensions )
        {
            if ( filename == null )
                return false;

            var fileExtension = Path.GetExtension( filename );
            var fileExtensionWithoutPeriod = fileExtension.TrimStart( '.' );

            foreach ( var extension in extensions )
            {
                var extensionWithoutPeriod = extension.TrimStart( '.' );
                if ( fileExtensionWithoutPeriod.Equals( extensionWithoutPeriod, StringComparison.InvariantCultureIgnoreCase ) )
                    return true;
            }

            return false;
        }
    }
}
