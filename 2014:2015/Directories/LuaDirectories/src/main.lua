require 'lfs' --lua file system

local function scandir(directory)
  local i = 1
  io.write(directory.."\n")
  for filename in lfs.dir(directory) do
    if lfs.attributes(filename, "mode") == "file" then 
      io.write(i.. " "..filename.." (file)\n")
      i = i + 1
    elseif lfs.attributes(filename, "mode") == "directory" then
      io.write(i.. " "..filename.." (dir)\n")
      i = i + 1
    else
      io.write(i .. " " .. filename.."\n")
    end
  end
end

local function createdir(directory, name)
  if directory[directory.len] == "/" then
    lfs.mkdir(directory..name)
  else
    lfs.mkdir(directory.."/"..name)
  end
end

local function removedir(directory)
  lfs.rmdir(directory)
end

local function menu()
  --os.execute('clear')
  io.write("\n\r")
  io.write("1 ... get all directories\n")
  io.write("2 ... create directory\n")
  io.write("3 ... remove directory\n")
  return io.read()
end

local function main()
  local menuselect, input, answer
  repeat
    menuselect = menu()
    if(menuselect == "1") then
      io.write("Enter the directory's path: ")
      input = io.read()
      scandir(input)
    elseif(menuselect == "2") then
      local dir, name
      io.write("Enter the path to the directory you want to put your folder into: ")
      dir = io.read()
      io.write("Enter the new folder's name: ")
      name = io.read()
      createdir(dir, name)
    elseif(menuselect == "3") then
      io.write("Enter the path of the directory you want to remove: ")
      input = io.read()
      removedir(input)
    end
    io.write("Do you want to take another action? (y/n) ")
    answer = io.read()
  until string.lower(answer) == "n"
end

main()