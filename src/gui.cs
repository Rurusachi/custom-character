// SPDX-License-Identifier: MIT

using Hexa.NET.ImGui;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrenheit.Mods.CustomCharacter.GUI;

public unsafe static class CustomCharacterGUI {

    public static bool override_FUN_00a505e0 = true;
    public static bool override_FUN_00a534c0 = true;
    public static void render() {
#if DEBUG
        renderDebug();
#endif
    }

    public static void renderDebug() {

        if (ImGui.Begin("CustomCharacter###CustomCharacter.GUI")) {
            ImGui.Checkbox("FUN_00a505e0", ref override_FUN_00a505e0);
            ImGui.Checkbox("FUN_00a534c0", ref override_FUN_00a534c0);
        }
        ImGui.End();
    }
}
