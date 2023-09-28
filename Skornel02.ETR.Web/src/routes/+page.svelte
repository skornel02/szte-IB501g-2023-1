<main>
    <h2><b>E</b>ntergalaktikus <b>T</b>anulmányi <b>R</b>endszer</h2>
    <article>
        <div id="spacer">

        </div>
        <div id="buttons">
            <a href="hallgato/login" class="paper-btn">
                Hallgatók / Students
            </a>
            <a href="oktato/login" class="paper-btn">
                Oktatók / Teachers
            </a>
        </div>
    </article>
</main>

<style>
    :root {
        --background-color: rgb(112, 80, 255);
        --text-color: rgb(255, 255, 255);
    }

    main {
        display: flex;
        flex-direction: column;
        min-height: 100vh;
        background-color: var(--background-color);
    }

    h2 {
        color: var(--text-color);
        text-align: center;
    }

    article {
        width: 1000px;
        height: 650px;
        margin: 0 auto;
        background-image: url('https://placehold.co/1000x450/EEE/31343C');
        background-repeat: no-repeat;

        display: flex;
        flex-direction: column;
        justify-content: start;
    }

    #spacer {
        height: 175px;
    }

    #buttons {
        display: flex;
        justify-content: space-around;
    }

    a {
        border-radius: 50px;
        background-color: var(--background-color);
        color: var(--text-color);
    }
</style>