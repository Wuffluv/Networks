import matplotlib

def manchester(low, high):
    y = []
    for i in range(8):
        if raw_data[i] == 0:
            y.extend([low, low, high, high])
            plt.annotate("", xy=(i + 0.5, low + 0.51), xytext=(i + 0.5, low + 0.49),
                         arrowprops=dict(arrowstyle="->", connectionstyle="arc3"))
        elif raw_data[i] == 1:
            y.extend([high, high, low, low])
            plt.annotate("", xy=(i + 0.5, low + 0.49), xytext=(i + 0.5, low + 0.51),
                         arrowprops=dict(arrowstyle="->", connectionstyle="arc3"))
    plt.plot(x_standard, y)
