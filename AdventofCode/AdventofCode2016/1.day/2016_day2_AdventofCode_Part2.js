var input = ""
var split = input.split(", ");
var current_orientation = "N";
var x = 0;
var y = 0;
var visited_position = [];
var printed = false;
for(var i = 0; i < split.length; i++) {
    if(split[i][0] == "R")
    {
        current_orientation = FacingRight(current_orientation);
    }
    else if(split[i][0] == "L")
    {
        current_orientation = FacingLeft(current_orientation);
    }

    for(var u = 0; u < parseInt(split[i].substring(1)); u++)
    {
        var new_position = x + ":" + y;
        for(var a = 0; a < visited_position.length; a++)
        {
            if(visited_position[a] == new_position)
            {
                if(printed == false)
                {
                    printed = true;
                }
            }
        }
        visited_position.push(new_position);

        if(current_orientation == "N")
        {
            y += 1;
        }
        if(current_orientation == "E")
        {
            x += 1;
        }
        if(current_orientation == "S")
        {
            y -= 1;
        }
        if(current_orientation == "W")
        {
            x -= 1;
        }
    }
}

function FacingRight(direction)
{
    if(direction == "N")
    {
        return "E"
    }
    else if(direction == "E")
    {
        return "S"
    }
    else if(direction == "S")
    {
        return "W"
    }
    else if(direction == "W")
    {
        return "N"
    }
}

function FacingLeft(direction)
{
    if(direction == "N")
    {
        return "W"
    }
    else if(direction == "W")
    {
        return "S"
    }
    else if(direction == "S")
    {
        return "E"
    }
    else if(direction == "E")
    {
        return "N"
    }
}