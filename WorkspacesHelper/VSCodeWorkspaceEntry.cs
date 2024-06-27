﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json.Serialization;

namespace Flow.Plugin.CursorWorkspaces.WorkspacesHelper
{
    public class CursorWorkspaceEntry
    {
        [JsonPropertyName("folderUri")]
        public string FolderUri { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }
    }
}
