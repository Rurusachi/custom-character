// SPDX-License-Identifier: MIT

using Hexa.NET.ImGui;

namespace Fahrenheit.Mods.CustomCharacter.GUI;

public unsafe static class CustomCharacterGUI {

    public static void render() {
#if DEBUG
        renderDebug();
#endif
    }

    public static void renderDebug() {
    }
}
