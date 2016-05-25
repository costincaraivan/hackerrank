chapters, problems_per_page = input().split(" ")
chapters, problems_per_page = int(chapters), int(problems_per_page)

problems_per_chapter = [ list(range(1, int(e) + 1)) for e in input().split() ]

pages = []
for index, problems in enumerate(problems_per_chapter):
    pages.extend([problems[e: e + problems_per_page] for e in range(0, len(problems), problems_per_page)])

count = 0
for index, page in enumerate(pages):
    if index + 1 in page:
        count += 1

print(count)
