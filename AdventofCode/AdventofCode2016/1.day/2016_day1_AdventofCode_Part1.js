var input = ""
var split = input.split(", ");
var current_orientation = "N";
var x = 0;
var y = 0;
for(var i = 0; i < split.length; i++) {
    if(split[i][0] == "R")
    {
        current_orientation = FacingRight(current_orientation);
    }
    else if(split[i][0] == "L")
    {
        current_orientation = FacingLeft(current_orientation);
    }

    if(current_orientation == "N")
    {
        y += parseInt(split[i].substring(1));
    }
    if(current_orientation == "E")
    {
        x += parseInt(split[i].substring(1));
    }
    if(current_orientation == "S")
    {
        y -= parseInt(split[i].substring(1));
    }
    if(current_orientation == "W")
    {
        x -= parseInt(split[i].substring(1));
    }
}

console.log(Math.abs(x) + Math.abs(y));

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