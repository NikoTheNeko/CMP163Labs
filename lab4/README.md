https://drive.google.com/file/d/1n4pwe_IgdHIl-4KBjAX_u0qLPMOYjl03/view?usp=sharing

Cube 1: Middle Rock Cube
followed indstructions
Cube 2: Left Middle Rock Cube
followed indstructions
Cube 3: Top Middle Grass Cube (Without Normalmap to the left)
followed indstructions, changed the texture and normalmap
Cube 4: Right Middle Cube
followed indstructions
Cube 5: Top Right Cube
Edited the shader file, so that it had a multiplier, and so that way it scales to a certain number (how many times it should be repeated), then for each x and y, i subtracted the whole number so that way it would get the uv correctly
:)

Part 24
A) x = (u * 8) - 1
B) y = 7 - ((v * 8) - 1)
C) x = Light Greay
x = (.375 * 8) - 1
x = 3 - 1
x = 2

y = 7 - ((.25 * 8) - 1)
y = 7 - ((2 - 1)
y = 7 - 1
y = 6
Texel Coords = (2, 6) = Light Greay
