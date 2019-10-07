<template>
    <div>
        <h1 class="text-center">Li-Iron Battery Test Bench</h1>
        <br />
        <div>
            <a href="https://localhost:44354/home/Shortccttest" style="border-style: groove;">Short Circuit Test</a>
        </div>
        <br />
        <div>
            <span><a style="border-style: groove;">State of Health (SOH)</a></span><span><input type="text" id="soh"/></span>
        </div>
        <br />
        <div>
            <span><a style="border-style: groove;">State of Charge (SOC)</a></span><span><input type="text" id="soc" /></span>
        </div>
        <br />
        <div>
            <span><a style="border-style: groove;">Rated Capacity</a></span><span><input type="text" id="rc" /></span>
        </div>
        <br />
        <div>
            <a href="https://localhost:44354/home/ChargeRetention" style="border-style: groove;">Charge Retention And Recovery</a>
        </div>
        <br />
        <div>
            <a href="https://localhost:44354/home/ChargeRecovery" style="border-style: groove;">Charge Recovery After Storage</a>
        </div>
        <br />
        <div>
            <a href="https://localhost:44354/home/Enduarance" style="border-style: groove;">Enduarance In Cycles</a>
        </div>
        <br />
        <div>
            <a href="https://localhost:44354/home/CCTest" style="border-style: groove;">Continuous Charge Set</a>
        </div>
        <br />
        <div>
            <a href="https://localhost:44354/home/OverchargeTest" style="border-style: groove;">Overcharge Test</a>
        </div>
        <br />
        <div>
            <a href="https://localhost:44354/home/Result" style="border-style: groove;">Result sheet</a>
        </div>
        <br />
    </div>
</template>
<script>
    export default {
        name: 'home-component'
    };

</script>