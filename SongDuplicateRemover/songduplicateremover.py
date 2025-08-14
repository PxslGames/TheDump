import os
import hashlib
from collections import defaultdict

def hash_file(file_path):
    """Generate MD5 hash for a file to identify duplicates."""
    hash_md5 = hashlib.md5()
    try:
        with open(file_path, "rb") as f:
            for chunk in iter(lambda: f.read(4096), b""):
                hash_md5.update(chunk)
        return hash_md5.hexdigest()
    except Exception as e:
        print(f"Error hashing file {file_path}: {e}")
        return None

def find_and_delete_duplicates(folder_path):
    """Find and delete duplicate files in the specified folder."""
    if not os.path.isdir(folder_path):
        print("Invalid folder path.")
        return

    hashes = defaultdict(list)

    # Walk through all files in the directory
    for root, _, files in os.walk(folder_path):
        for file in files:
            file_path = os.path.join(root, file)
            file_hash = hash_file(file_path)
            if file_hash:
                hashes[file_hash].append(file_path)

    # Identify and delete duplicates
    duplicates = [paths for paths in hashes.values() if len(paths) > 1]
    total_deleted = 0

    for duplicate_group in duplicates:
        original_file = duplicate_group[0]
        duplicate_files = duplicate_group[1:]

        for duplicate_file in duplicate_files:
            try:
                os.remove(duplicate_file)
                print(f"Deleted duplicate: {duplicate_file}")
                total_deleted += 1
            except Exception as e:
                print(f"Error deleting file {duplicate_file}: {e}")

    print(f"Total duplicates deleted: {total_deleted}")

if __name__ == "__main__":
    folder_path = input("Enter the path to the folder with songs: ").strip()
    find_and_delete_duplicates(folder_path)
